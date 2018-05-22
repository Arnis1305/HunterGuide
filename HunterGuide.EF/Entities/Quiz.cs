using System;
using System.ComponentModel.DataAnnotations;

namespace HunterGuide.EF.Entities 
{
    public class Quiz 
    {
        public Quiz() 
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string FirstAnswer { get; set; }

        [Required]
        public string SecondAnswer { get; set; }

        [Required]
        public string ThirdAnswer { get; set; }

        [Required]
        public string FourthAnswer { get; set; }

        [Required]
        public int CorrectAnswerNumber { get; set; }

        public Guid TestId { get; set; }

        public Test Test { get; set; }
    }
}
