﻿namespace FitHubWebApi.Infrastructure.Models
{
    public class Kcal
    {
        public int Value { get; set; }
        public int LogId { get; set; }

        public virtual Log Log { get; set; }
    }
}
