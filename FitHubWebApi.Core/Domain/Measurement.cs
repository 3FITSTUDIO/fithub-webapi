namespace FitHubWebApi.Core.Domain
{
    public class Measurement
    {
        public int Id { get; set; }
        public int? EntryId { get; set; }
        public int? Neck { get; set; }
        public int? Chest { get; set; }
        public int? Bicep { get; set; }
        public int? Forearm { get; set; }
        public int? Stomach { get; set; }
        public int? Waist { get; set; }
        public int? Thigh { get; set; }
        public int? Calf { get; set; }

        public virtual Entries Entry { get; set; }
    }
}
