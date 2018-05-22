using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HunterGuide.EF.Entities
{
    public class TestType 
    {
        public TestType() 
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        public string TypeName { get; set; }

        public List<Test> Tests { get; set; }
    }
}
