namespace FitHubWebApi.Infrastructure.Models
{
    public class Password
    {
        public int HashValue { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
