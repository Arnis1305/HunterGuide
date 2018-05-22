using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunterGuide.EF.Entities 
{
    public class UserTestResult 
    {
        public UserTestResult() 
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        public int Mark { get; set; }

        [Required]
        public DateTime CompletionDate { get; set; }

        [Required]
        [ForeignKey("ApplicationUser")]
        public Guid ApplicationUserId { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [ForeignKey("Test")]
        public Guid TestId { get; set; }

        public Test Test { get; set; }
    }
}
