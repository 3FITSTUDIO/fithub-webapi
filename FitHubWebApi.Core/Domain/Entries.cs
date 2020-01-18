using System.Collections.Generic;

namespace FitHubWebApi.Core.Domain
{
    public class Entries
    {
        public Entries()
        {
            Height = new HashSet<Height>();
            Kcal = new HashSet<Kcal>();
            Measurement = new HashSet<Measurement>();
            Weight = new HashSet<Weight>();
        }

        public int Id { get; set; }
        public int? LogId { get; set; }
        public int? EntryTypeId { get; set; }

        public virtual EntryType EntryType { get; set; }
        public virtual Log Log { get; set; }
        public virtual ICollection<Height> Height { get; set; }
        public virtual ICollection<Kcal> Kcal { get; set; }
        public virtual ICollection<Measurement> Measurement { get; set; }
        public virtual ICollection<Weight> Weight { get; set; }
    }
}
