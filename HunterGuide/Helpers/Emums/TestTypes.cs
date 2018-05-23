using System.Collections.Generic;

namespace HunterGuide.Helpers.Emums {
    public static class TestTypes 
    {
        public static readonly IReadOnlyCollection<string> TestTypeNames = new List<string>(
                new string[] 
                {
                    "Training test",
                    "Set-off test",
                    "Exam test"
                }
            );

        public enum TestTypesEnum
        {
            Training,
            SetOff,
            Exam
        }
    }
}
