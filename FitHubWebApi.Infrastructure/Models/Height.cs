namespace FitHubWebApi.Infrastructure.Models
{
    public class Height
    {
        public int Value { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
