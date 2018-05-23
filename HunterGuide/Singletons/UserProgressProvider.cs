using HunterGuide.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterGuide.Singletons 
{
    public class UserProgressProvider
    {
        private static UserProgressProvider userProgressProvider;

        private List<KeyValuePair<int, int>> quizesAndAnswers;

        private UserProgressProvider() 
        {
            quizesAndAnswers = new List<KeyValuePair<int, int>>();
        }

        public void RecordAnswer(int correctAnswer, int userAnswer)
        {
            quizesAndAnswers.Add(new KeyValuePair<int, int>(correctAnswer, userAnswer));
        }

        public int CalculateProgress() 
        {
            int numberOfAnswers = quizesAndAnswers.Count;
            int correctAnswers = quizesAndAnswers.Count(q => q.Key == q.Value);
            return correctAnswers / numberOfAnswers * 100;
        }

        public static UserProgressProvider StartNewTest() 
        {
            userProgressProvider = new UserProgressProvider();
            return userProgressProvider;
        }

        public static void DropTest() 
        {
            userProgressProvider = null;
        }

        public static UserProgressProvider GetInstance() 
        {
            return userProgressProvider;
        }
    }
}
