namespace FitHubWebApi.Core.DTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string AccountType { get; set; }
        public string Height { get; set; }
        public string Password { get; set; }
    }
}
