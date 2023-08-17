namespace OgrenciServis.Domain.Entities
{
    public class Parent : Personel
    {
        public ICollection<Child>? Childs { get; set; }
        public ICollection<Kinship>? Kinships { get; set; } // akrabalık yakınlık derecesi..
    }
}
