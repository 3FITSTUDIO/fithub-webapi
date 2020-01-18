namespace FitHubWebApi.Core.Domain
{
    public class Height
    {
        public int Id { get; set; }
        public int? EntryId { get; set; }
        public int Val { get; set; }

        public virtual Entries Entry { get; set; }
    }
}
