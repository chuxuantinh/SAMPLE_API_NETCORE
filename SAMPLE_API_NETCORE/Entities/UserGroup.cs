using System;
using System.Collections.Generic;

namespace SAMPLE_API_NETCORE.Entities
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            UserLogins = new HashSet<UserLogin>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<UserLogin> UserLogins { get; set; }
    }
}
