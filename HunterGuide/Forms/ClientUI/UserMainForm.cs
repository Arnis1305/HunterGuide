using HunterGuide.EF.Entities;
using HunterGuide.Helpers.Emums;
using HunterGuide.Singletons;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HunterGuide.Forms.ClientUI
{
    public partial class UserMainForm : MetroForm
    {
        private readonly EF.ApplicationContext context;
        private readonly ApplicationUser user;
        private TestTypes.TestTypesEnum testType;

        private static Random random = new Random();

        public UserMainForm(ApplicationUser user)
        {
            InitializeComponent();

            context = ContextProvider.GetApplicationContext();
            this.user = user;

            TestTopicsComboBox.Visible = false;
            TestNamesComboBox.Visible = false;
            StartTestButton.Enabled = false;
            SetItemsToTypeComboBox();
        }

        private void SetItemsToTypeComboBox() 
        {
            var testTypes = context.TestTypes.ToList();
            TestTypesComboBox.Items.Clear();
            TestTypesComboBox.Items.AddRange(testTypes.Select(t => t.TypeName).OrderByDescending(tn => tn).ToArray());
            TestTypesComboBox.SelectedIndex = 0;
        }

        private void SetItemsToTopicComboBox() 
        {
            var testTopics = context.TestTopics.ToList();
            TestTopicsComboBox.Items.Clear();
            TestTopicsComboBox.Items.AddRange(testTopics.Select(t => t.TopicName).OrderBy(tn => tn).ToArray());
            TestTopicsComboBox.SelectedIndex = 0;
        }

        private void SetItemsToTestNamesComboBox() 
        {
            Guid typeId = GetSelectedTypeId();
            Guid topicId = GetSelectedTopicId();

            var tests = context.Tests.Where(t => t.TestTopicId == topicId && t.TestTypeId == typeId).ToList();
            TestNamesComboBox.Items.Clear();
            TestNamesComboBox.Items.AddRange(tests.Select(t => t.Name).OrderBy(tn => tn).ToArray());
            if (tests.Count > 0)
            {
                StartTestButton.Enabled = true;
                TestNamesComboBox.Visible = true;
                TestNamesComboBox.SelectedIndex = 0;
            }
            else 
            {
                StartTestButton.Enabled = false;
            }
        }

        private Guid GetSelectedTypeId() 
        {
            string typeName = TestTypesComboBox.SelectedItem as string;
            return context.TestTypes.FirstOrDefault(t => t.TypeName.Equals(typeName)).Id;
        }

        private Guid GetSelectedTopicId() 
        {
            string topicName = TestTopicsComboBox.SelectedItem as string;
            return context.TestTopics.FirstOrDefault(t => t.TopicName.Equals(topicName)).Id;
        }

        private Guid GetSelectedTestId() 
        {
            string testName = TestNamesComboBox.SelectedItem as string;
            return context.Tests.FirstOrDefault(t => t.Name.Equals(testName)).Id;
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            UserResultsForm URF = new UserResultsForm(user.Id);
            URF.ShowDialog();
        }

        private void StartTestButton_Click(object sender, EventArgs e) 
        {
            Guid testId;

            if (testType == TestTypes.TestTypesEnum.Exam) 
            {
                testId = GetRandomTestIdForExamination();
            }
            else if (testType == TestTypes.TestTypesEnum.SetOff) 
            {
                testId = GetRandomTestIdForSetOff();
            }
            else 
            {
                string testName = TestNamesComboBox.SelectedItem as string;
                testId = context.Tests.FirstOrDefault(t => t.Name == testName).Id;
            }

            OpenTest(testId);
        }

        private void OpenTest(Guid testId) 
        {
            UserProgressProvider.StartNewTest();
            QuestionsForm questionsForm = new QuestionsForm(testId, 0);
            Hide();
            questionsForm.FormClosed += (s, args) =>
            {
                if (UserProgressProvider.GetInstance() != null) 
                {
                    int progress = UserProgressProvider.GetInstance().CalculateProgress();
                    AddProgress(testId, progress);
                }
                
                Show();
            };
            questionsForm.ShowDialog();
        }

        private void AddProgress(Guid testId, int progress) 
        {
            var result = context.UserTestsResults.Add(new UserTestResult {
                                ApplicationUserId = user.Id,
                                CompletionDate = DateTime.Now,
                                Mark = progress,
                                TestId = testId
                            });
            context.SaveChanges();
            ShowProgressWindow(result.Id);
        }

        private void ShowProgressWindow(Guid resultId)
        {
            TimeResultForm timeResultForm = new TimeResultForm(resultId);
            timeResultForm.ShowDialog();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestTypesComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            string selectedItem = TestTypesComboBox.SelectedItem as string;
            for (int i = 0; i < TestTypes.TestTypeNames.Count; i++)
            {
                if (TestTypes.TestTypeNames.ElementAt(i) == selectedItem) 
                {
                    testType = (TestTypes.TestTypesEnum)i;
                }
            }
            ShowElementsDependentOnTestType();
        }

        private void ShowElementsDependentOnTestType() 
        {
            if (testType == TestTypes.TestTypesEnum.Training)
            {
                TestTopicsComboBox.Visible = true;
                TestNamesComboBox.Visible = true;
                SetItemsToTopicComboBox();
                SetItemsToTestNamesComboBox();
            }
            else if (testType == TestTypes.TestTypesEnum.SetOff)
            {
                TestTopicsComboBox.Visible = true;
                TestNamesComboBox.Visible = false;
                SetItemsToTopicComboBox();
                CheckForTestsAvailableForSetOff();
            }
            else
            {
                TestTopicsComboBox.Visible = false;
                TestNamesComboBox.Visible = false;
                CheckForTestsAvailableForExam();
            }
        }

        private void CheckForTestsAvailableForExam() 
        {
            string type = TestTypesComboBox.SelectedItem as string;
            int countOfTests = context.Tests.Count(t => t.TestType.TypeName == type);
            StartTestButton.Enabled = countOfTests > 0;
        }

        private void CheckForTestsAvailableForSetOff() 
        {
            string type = TestTypesComboBox.SelectedItem as string;
            string topic = TestTopicsComboBox.SelectedItem as string;
            int countOfTests = context.Tests.Count(t => t.TestType.TypeName == type && t.TestTopic.TopicName == topic);
            StartTestButton.Enabled = countOfTests > 0;
        }

        private Guid GetRandomTestIdForExamination() 
        {
            string type = TestTypesComboBox.SelectedItem as string;
            var tests = context.Tests.Where(t => t.TestType.TypeName == type).ToList();
            int randomTest = random.Next(0, tests.Count);
            return tests[randomTest].Id;
        }

        private Guid GetRandomTestIdForSetOff()
        {
            string type = TestTypesComboBox.SelectedItem as string;
            string topic = TestTopicsComboBox.SelectedItem as string;
            var tests = context.Tests.Where(t => t.TestType.TypeName == type && t.TestTopic.TopicName == topic).ToList();
            int randomTest = random.Next(0, tests.Count);
            return tests[randomTest].Id;
        }

        private void TestTopicsComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (testType == TestTypes.TestTypesEnum.Training) 
            {
                SetItemsToTestNamesComboBox();
            }
            else
            {
                CheckForTestsAvailableForSetOff();
            }
        }

        private void TestNamesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TestNamesComboBox.SelectedItem != null) 
            {
                StartTestButton.Enabled = true;
            }
        }
    }
}
