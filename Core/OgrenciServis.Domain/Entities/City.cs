namespace OgrenciServis.Domain.Entities
{
    public class City:BaseEntity
    {
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public string? CityDescription { get; set; }
        public ICollection<District>? Districts { get; set; }
        public Country? Country { get; set; }
    }
}