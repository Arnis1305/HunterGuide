namespace HunterGuide.EF.Migrations
{
    using HunterGuide.EF.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HunterGuide.EF.ApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HunterGuide.EF.ApplicationContext context)
        {
            if (context.Users.Count() == 0)
            {
                context.Users.Add(new ApplicationUser
                {
                    Username = "admin",
                    FirstName = "admin",
                    LastName = "admin",
                    PasswordHash = "7CeKOJASh7J3GhNzlSA4TUPksHj3iv/nAt7xCHdMziQ=",
                    RoleId = context.Roles.FirstOrDefault(r => r.RoleName.Equals("Admin")).Id,
                    StatusType = 2
                });
                context.Users.Add(new ApplicationUser
                {
                    Username = "user",
                    FirstName = "user",
                    LastName = "user",
                    PasswordHash = "7CeKOJASh7J3GhNzlSA4TUPksHj3iv/nAt7xCHdMziQ=",
                    RoleId = context.Roles.FirstOrDefault(r => r.RoleName.Equals("User")).Id,
                    StatusType = 2
                });
            }

            if (context.TestTypes.Count() == 0) 
            {
                context.TestTypes.Add(new TestType { TypeName = "Training test" });
                context.TestTypes.Add(new TestType { TypeName = "Set-off test" });
                context.TestTypes.Add(new TestType { TypeName = "Exam test" });
            }

            if (context.TestTopics.Count() == 0)
            {
                context.TestTopics.Add(new TestTopic { TopicName = "Test 1" });
                context.TestTopics.Add(new TestTopic { TopicName = "Test 2" });
                context.TestTopics.Add(new TestTopic { TopicName = "Test 3" });
                context.TestTopics.Add(new TestTopic { TopicName = "Test 4" });
                context.TestTopics.Add(new TestTopic { TopicName = "Test 5" });
            }
        }
    }
}
