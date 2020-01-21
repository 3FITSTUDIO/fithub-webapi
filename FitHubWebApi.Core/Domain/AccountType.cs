using System.Collections.Generic;
using FitHubWebApi.Core.Domain.Base;

namespace FitHubWebApi.Core.Domain
{
    public class AccountType : Entity<int>
    {
        public AccountType()
        {
            User = new HashSet<User>();
        }

        public string Type { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
