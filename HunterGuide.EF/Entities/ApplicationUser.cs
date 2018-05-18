using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace HunterGuide.EF.Entities
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid();
            IsActivated = false;
            IsRejected = false;
        }

        public Guid Id { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PasswordHash { get; set; }

        public bool IsActivated { get; set; }

        public bool IsRejected { get; set; }

        [ForeignKey("Role")]
        public Guid RoleId { get; set; }

        public Role Role { get; set; }
    }
}
