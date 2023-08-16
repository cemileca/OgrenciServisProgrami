namespace OgrenciServis.Domain.Entities
{
    public class Country:BaseEntity
    {
        public string CountryName { get; set; }
        public string? UlkeCountryCode { get; set; }
        public ICollection<City>? Cities { get; set; }
    }
}