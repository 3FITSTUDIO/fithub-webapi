using System.Collections.Generic;

namespace FitHubWebApi.Infrastructure.Models
{
    public class EntryType
    {
        public EntryType()
        {
            Entries = new HashSet<Entries>();
        }

        public int Id { get; set; }
        public string Type { get; set; }

        public virtual ICollection<Entries> Entries { get; set; }
    }
}
