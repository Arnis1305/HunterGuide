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
using HunterGuide.Models;
using HunterGuide.Singletons;
using AutoMapper;
using HunterGuide.Validators;
using HunterGuide.Exceptions;
using HunterGuide.EF.Entities;

namespace HunterGuide.Forms.AdminUI
{
    public partial class NewTestForm : MetroForm
    {
        private IMapper mapper;
        private EF.ApplicationContext context;
        private NewTestModelValidator newTestModelValidator;

        public NewTestForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();
            newTestModelValidator = new NewTestModelValidator();

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

        private void CreateTestButton_Click(object sender, EventArgs e)
        {
            var model = GetNewTestModelFromInputs();
            try {
                newTestModelValidator.Validate(model);
                AddModelToDatabase(model);
                ShowSteps(Convert.ToInt32(NumQwBox.Value));
            }
            catch (ValidationException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowSteps(int numberOfSteps) 
        {
            for (int i = 0; i < numberOfSteps; ) 
            {
                QwestForm QF = new QwestForm(i + 1);
                QF.FormClosed += (s, args) => {
                    i++;
                };
                QF.ShowDialog();
            }
        }

        private Test AddModelToDatabase(NewTestModel model) 
        {
            var test = MapNewTestModelToTestEntity(model);
            test = context.Tests.Add(test);
            context.SaveChanges();
            return test;
        }

        private Test MapNewTestModelToTestEntity(NewTestModel model) 
        {
            var test = mapper.Map<Test>(model);
            test.TestTopicId = context.TestTopics.FirstOrDefault(t => t.TopicName.Equals(model.TopicName)).Id;
            test.TestTypeId = context.TestTypes.FirstOrDefault(t => t.TypeName.Equals(model.TypeName)).Id;
            return test;
        }

        private NewTestModel GetNewTestModelFromInputs() 
        {
            return new NewTestModel {
                Name = NameBox.Text,
                TypeName = TestTypesComboBox.SelectedItem as string,
                TopicName = TestTopicsComboBox.SelectedItem as string
            };
        }
    }
}
