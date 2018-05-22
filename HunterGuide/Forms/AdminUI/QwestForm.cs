using AutoMapper;
using HunterGuide.EF.Entities;
using HunterGuide.Exceptions;
using HunterGuide.Models;
using HunterGuide.Singletons;
using HunterGuide.Validators;
using MetroFramework.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace HunterGuide.Forms.AdminUI {
    public partial class QwestForm : MetroForm
    {
        private readonly IMapper mapper;
        private readonly EF.ApplicationContext context;

        private readonly Guid testId;

        private QuizModelValidator quizModelValidator;

        public QwestForm(Guid testId, int stepNumber, int numberOfSteps)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            mapper = AutoMapperProvider.GetIMapper();
            context = ContextProvider.GetApplicationContext();
            this.testId = testId;

            this.Text = string.Format("Question #{0}/{1}", stepNumber, numberOfSteps);
            if (stepNumber == numberOfSteps) 
            {
                ContinueButton.Text = "End";
            }

            quizModelValidator = new QuizModelValidator();
        }

        private void CloseButton_Click(object sender, EventArgs e) 
        {
            OnCascadeDelete();
            Close();
        }

        private void ContinueButton_Click(object sender, EventArgs e) 
        {
            var model = GetQuizModelFromInputs();
            try {
                quizModelValidator.Validate(model);
                AddQuizToDatabase(model);
                Close();
            }
            catch (ValidationException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private Quiz AddQuizToDatabase(QuizModel model) 
        { 
            var quiz = mapper.Map<Quiz>(model);
            quiz.TestId = testId;
            quiz = context.Quizes.Add(quiz);
            context.SaveChanges();
            return quiz;
        }

        private void OnCascadeDelete() 
        {
            var test = context.Tests.FirstOrDefault(t => t.Id == testId);
            if (test != null) 
            {
                context.Tests.Remove(test);
                context.SaveChanges();
            }
        }

        private QuizModel GetQuizModelFromInputs()
        {
            return new QuizModel {
                Question = QwestBox.Text,
                FirstAnswer = FirstAnswerBox.Text,
                SecondAnswer = SecondAnswerBox.Text,
                ThirdAnswer = ThirdAnswerBox.Text,
                FourthAnswer = FourthAnswerBox.Text,
                CorrectAnswerNumber = Convert.ToInt32(NumQwBox.Value)
            };
        }
    }
}
