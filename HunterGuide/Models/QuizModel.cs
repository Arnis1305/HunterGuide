using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterGuide.Models 
{
    public class QuizModel 
    {
        public string Question { get; set; }

        public string FirstAnswer { get; set; }

        public string SecondAnswer { get; set; }

        public string ThirdAnswer { get; set; }

        public string FourthAnswer { get; set; }

        public int CorrectAnswerNumber { get; set; }

        public Guid TestId { get; set; }
    }
}
