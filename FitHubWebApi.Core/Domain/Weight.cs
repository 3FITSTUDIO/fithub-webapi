﻿namespace FitHubWebApi.Core.Domain
{
    public class Weight
    {
        public int Vale { get; set; }
        public int LogId { get; set; }

        public virtual Log Log { get; set; }
    }
}
