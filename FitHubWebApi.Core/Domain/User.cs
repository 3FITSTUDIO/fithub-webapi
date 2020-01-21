using FitHubWebApi.Core.Domain.Base;

namespace FitHubWebApi.Core.Domain
{
    public class User : Entity<int>
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AccountTypeId { get; set; }
        public int Password { get; set; }
        public int Height { get; set; }

        public virtual AccountType AccountType { get; set; }
    }
}
