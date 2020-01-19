using System.Collections.Generic;

namespace FitHubWebApi.Core.Domain
{
    public class AccountType
    {
        public AccountType()
        {
            User = new HashSet<User>();
        }

        public string Type { get; set; }
        public int Id { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
