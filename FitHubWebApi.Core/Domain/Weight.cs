﻿namespace FitHubWebApi.Core.Domain
{
    public class Weight
    {
        public int Value { get; set; }
        public int LogId { get; set; }

        public virtual Log Log { get; set; }
    }
}
