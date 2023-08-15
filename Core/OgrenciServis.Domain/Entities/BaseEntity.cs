using System.ComponentModel.DataAnnotations;

namespace OgrenciServis.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
