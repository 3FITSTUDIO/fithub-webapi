using System;
using System.Collections.Generic;

namespace FitHubWebApi.Core.Domain
{
    public class Log
    {
        public Log()
        {
            Entries = new HashSet<Entries>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime Created { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Entries> Entries { get; set; }
    }
}
