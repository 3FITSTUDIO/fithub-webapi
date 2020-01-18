using System.Collections.Generic;

namespace FitHubWebApi.Infrastructure.Models
{
    public class Users
    {
        public Users()
        {
            Logs = new HashSet<Logs>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? AccountTypeId { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Passwords Passwords { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
    }
}
