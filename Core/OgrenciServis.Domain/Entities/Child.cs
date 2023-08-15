namespace OgrenciServis.Domain.Entities
{
    public class Child : Personel
    {
        public int ParentId { get; set; }
        public ICollection<Parent>? Parents { get; set; }
        public DateTime BeginingDate { get; set; } // Servis hizmeti almaya başlama tarihi
        public DateTime? EndDate { get; set; } // Servis hizmetini almayı  bitirme tarihi
        public decimal? ServiceCost { get; set; }
    }
}
