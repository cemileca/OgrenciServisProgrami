namespace OgrenciServis.Domain.Entities
{
    public class Adress:BaseEntity
    {
        public string AdressName { get; set; }
        public string? AdresDescription { get; set; }
        public Country? Country { get; set; }
        public City? City { get; set; }
        public District? District { get; set; }
        public ICollection<Child> Childs { get; set; }
    }
}
