using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Domain.ViewModel
{
    public class VM_DistrictGetAll
    {
        public string DistrictName { get; set; }
        public string? DistrictDescription { get; set; }
        public string? DistrictZipCode { get; set; }
        public int CityId { get; set; }

    }
}
