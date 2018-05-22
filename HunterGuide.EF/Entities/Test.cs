using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunterGuide.EF.Entities 
{
    public class Test 
    {
        public Test()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        [ForeignKey("TestType")]
        public Guid TestTypeId { get; set; }

        public TestType TestType { get; set; }

        [Required]
        [ForeignKey("TestTopic")]
        public Guid TestTopicId { get; set; }

        public TestTopic TestTopic { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Quiz> Quizes { get; set; }

        public List<UserTestResult> UserTestResults { get; set; }
    }
}
