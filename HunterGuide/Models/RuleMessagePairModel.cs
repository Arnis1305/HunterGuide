using System;

namespace HunterGuide.Models {
    public class RuleMessagePairModel<T> 
    {
        public Func<T, bool> Rule { get; set; }

        public string WithMessage { get; set; }
    }
}
