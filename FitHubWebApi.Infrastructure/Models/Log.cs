using System;

namespace FitHubWebApi.Infrastructure.Models
{
    public  class Log
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UserId { get; set; }

        public virtual Kcal Kcal { get; set; }
        public virtual Weight Weight { get; set; }
        public virtual Steps Steps { get; set; }
    }
}
