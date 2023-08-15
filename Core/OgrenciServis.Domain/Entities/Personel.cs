namespace OgrenciServis.Domain.Entities
{
    public class Personel : BaseEntity
    {

        public string IndivudialNo { get; set; } // TC ve ya Pasaport Numarası 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? PhotoUrl { get; set; }
        public ICollection<Adress>? Adresses { get; set; }



    }
}
