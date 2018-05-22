using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using HunterGuide.Singletons;
using System.Collections.ObjectModel;
using HunterGuide.Models;
using AutoMapper;

namespace HunterGuide.Forms.AdminUI
{
    public partial class AllTestForm : MetroForm
    {
        private readonly IMapper mapper;
        private readonly EF.ApplicationContext context;

        public AllTestForm()
        {
            InitializeComponent();

            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();

            SetItemsToTypeComboBox();
            SetItemsToTopicComboBox();
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
                TestNamesComboBox.SelectedIndex = 0;
            }
            else 
            {
                QuizesDataGrid.DataSource = new ObservableCollection<QuizViewModel>();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void TestTopic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TestTypesComboBox.SelectedItem != null)
            {
                SetItemsToTestNamesComboBox();
            }
        }

        private void TestType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TestTopicsComboBox.SelectedItem != null)
            {
                SetItemsToTestNamesComboBox();
            }
        }

        private void TestNamesComboBox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            Guid testId = GetSelectedTestId();

            var quizes = context.Quizes.Where(t => t.TestId == testId).ToList();

            QuizesDataGrid.DataSource = new ObservableCollection<QuizViewModel>(mapper.Map<List<QuizViewModel>>(quizes));
        }
    }
}
