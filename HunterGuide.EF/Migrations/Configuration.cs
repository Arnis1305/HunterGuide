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
            context.Roles.Add(new Role { RoleName = "User" });
            context.Roles.Add(new Role { RoleName = "Admin" });
        }
    }
}
