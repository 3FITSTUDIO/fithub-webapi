namespace FitHubWebApi.Infrastructure.Models
{
    public class Steps
    {
        public int Value { get; set; }
        public int LogId { get; set; }

        public virtual Log Log { get; set; }
    }
}
