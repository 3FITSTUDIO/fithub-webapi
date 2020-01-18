using System.Collections.Generic;

namespace FitHubWebApi.Core.Domain
{
    public class User
    {
        public User()
        {
            Logs = new HashSet<Log>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? AccountTypeId { get; set; }

        public virtual AccountType AccountType { get; set; }
        public virtual Password Password { get; set; }
        public virtual ICollection<Log> Logs { get; set; }
    }
}
