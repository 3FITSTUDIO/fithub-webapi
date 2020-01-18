using FitHubWebApi.Core.Domain;
using System;
using System.Collections.Generic;

namespace FitHubWebApi.Infrastructure.Models
{
    public  class Logs
    {
        public Logs()
        {
            Entries = new HashSet<Entries>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime Created { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Entries> Entries { get; set; }
    }
}
