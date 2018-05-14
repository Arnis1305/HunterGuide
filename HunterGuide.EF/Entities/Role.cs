using System;

namespace HunterGuide.EF.Entities
{
    public class Role
    {
        public Role()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string RoleName { get; set; }
    }
}
