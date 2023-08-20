using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OgrenciServis.Domain.Entities
{
    public class Country : BaseEntity
    {
        public string CountryName { get; set; }
        public string? CountryCode { get; set; }
        public string CountryDescription { get; set; }
        public ICollection<City>? Cities { get; set; }
    }
}