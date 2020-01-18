using System.Collections.Generic;

namespace FitHubWebApi.Core.Domain
{
    public class AccountType
    {
        public AccountType()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
