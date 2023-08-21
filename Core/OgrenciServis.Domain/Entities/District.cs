namespace OgrenciServis.Domain.Entities
{
    public class District : BaseEntity
    {
        public string DistrictName { get; set; }
        public string? DistrictDescription { get; set; }
        public string? DistrictZipCode { get; set; }
        public City? City { get; set; }
        public ICollection<Adress>? Adresses { get; set; }
    }
}