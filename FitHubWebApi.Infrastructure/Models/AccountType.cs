using FitHubWebApi.Core.Domain;
using System.Collections.Generic;

namespace FitHubWebApi.Infrastructure.Models
{
    public class AccountType
    {
        public AccountType()
        {
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
