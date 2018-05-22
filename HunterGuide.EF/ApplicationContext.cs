using HunterGuide.EF.Entities;
using System.Data.Entity;

namespace HunterGuide.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ApplicationContext")
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Test> Tests { get; set; }

        public DbSet<TestTopic> TestTopics { get; set; }

        public DbSet<TestType> TestTypes { get; set; }

        public DbSet<UserTestResult> UserTestsResults { get; set; }
    }
}
