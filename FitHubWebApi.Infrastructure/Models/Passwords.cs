using FitHubWebApi.Core.Domain;

namespace FitHubWebApi.Infrastructure.Models
{
    public class Passwords
    {
        public int UserId { get; set; }
        public int HashValue { get; set; }

        public virtual Users User { get; set; }
    }
}
