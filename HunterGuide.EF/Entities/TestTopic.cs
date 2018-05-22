using System;
using System.Collections.Generic;

namespace HunterGuide.EF.Entities
{
    public class TestTopic 
    {
        public TestTopic() 
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string TopicName { get; set; }

        public List<Test> Tests { get; set; }
    }
}
