using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterGuide.Models
{
    public class UserResultModel
    {
        public string TestType { get; set; }

        public string TestName { get; set; }

        public string Username { get; set; }

        public int Mark { get; set; }

        public DateTime CompletionDate { get; set; }
    }
}
