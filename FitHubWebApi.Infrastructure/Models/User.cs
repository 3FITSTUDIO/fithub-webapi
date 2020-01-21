namespace FitHubWebApi.Infrastructure.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AccountTypeId { get; set; }
        public int Height { get; set; }
        public int Password { get; set; }

        public virtual AccountType AccountType { get; set; }
    }
}
