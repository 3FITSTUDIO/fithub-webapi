namespace FitHubWebApi.Core.Domain
{
    public class Password
    {
        public int UserId { get; set; }
        public int HashValue { get; set; }

        public virtual User User { get; set; }
    }
}
