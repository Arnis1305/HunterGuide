using HunterGuide.EF.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HunterGuide.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("name=ApplicationContext")
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
