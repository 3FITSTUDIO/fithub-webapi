using System;
using FitHubWebApi.Core.Domain.Base;

namespace FitHubWebApi.Core.Domain
{
    public class Log : Entity<int>
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UserId { get; set; }

        public virtual Kcal Kcal { get; set; }
        public virtual Steps Steps { get; set; }
        public virtual Weight Weight { get; set; }
    }
}
