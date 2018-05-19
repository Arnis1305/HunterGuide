using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunterGuide.EF.Entities
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            StatusType = 1;
        }

        public Guid Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public int StatusType { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}
