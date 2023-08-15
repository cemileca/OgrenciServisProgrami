namespace OgrenciServis.Domain.Entities
{
    public class Parent : Personel
    {
        public int ChildId { get; set; }
        public int KinshipId { get; set; }
        public ICollection<Child>? Childs { get; set; }
        public ICollection<Kinship>? Kinships { get; set; } // akrabalık yakınlık derecesi..
    }
}
