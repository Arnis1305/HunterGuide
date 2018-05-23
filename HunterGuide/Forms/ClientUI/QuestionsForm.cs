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
using HunterGuide.EF.Entities;

namespace HunterGuide.Forms.ClientUI
{
    public partial class QuestionsForm : MetroForm
    {
        private readonly EF.ApplicationContext context;

        private int stepNumber;
        private int quizesCount;
        private UserProgressProvider userProgress;
        private Quiz currentQuiz;

        public QuestionsForm(Guid testId, int stepNumber)
        {
            InitializeComponent();

            context = ContextProvider.GetApplicationContext();
            userProgress = UserProgressProvider.GetInstance();

            GetTestInfo(testId, stepNumber);
        }

        private void GetTestInfo(Guid testId, int stepNumber)
        {
            var quizes = context.Quizes.Where(t => t.TestId == testId).ToList();
            quizesCount = quizes.Count;

            if (quizesCount == stepNumber + 1) 
            {
                NextQwButton.Text = "End";
            }
            else 
            {
                NextQwButton.Text = "Next quiz";
            }

            this.Text = "Quiz #" + (stepNumber + 1) + " of " + quizesCount;

            currentQuiz = quizes.ElementAt(stepNumber);
            this.stepNumber = stepNumber;
            SetTest();
        }

        private void SetTest() 
        {
            QuizHeader.Text = currentQuiz.Question;

            Answ1.Text = currentQuiz.FirstAnswer;
            Answ2.Text = currentQuiz.SecondAnswer;
            Answ3.Text = currentQuiz.ThirdAnswer;
            Answ4.Text = currentQuiz.FourthAnswer;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            UserProgressProvider.DropTest();
            this.Close();
        }

        private void NextQwButton_Click(object sender, EventArgs e)
        {
            int answer = GetAnswerNumberFromInputs();

            userProgress.RecordAnswer(currentQuiz.CorrectAnswerNumber, answer);

            if (stepNumber + 1 == quizesCount) 
            {
                Close();
            }
            else
            {
                QuestionsForm questionsForm = new QuestionsForm(currentQuiz.TestId, stepNumber + 1);
                Hide();
                questionsForm.FormClosed += (s, args) => Close();
                questionsForm.ShowDialog();
            }
        }

        private int GetAnswerNumberFromInputs() 
        {
            if (Answ1.Checked) {
                return 1;
            }
            if (Answ2.Checked) {
                return 2;
            }
            if (Answ3.Checked) {
                return 3;
            }
            return 4;
        }
    }
}
