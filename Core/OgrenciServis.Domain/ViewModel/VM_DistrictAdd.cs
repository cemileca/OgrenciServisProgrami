﻿using OgrenciServis.Domain.Entities;

namespace OgrenciServis.Domain.ViewModel
{
    public class VM_DistrictAdd
    {
        public string DistrictName { get; set; }
        public string? DistrictZipCode { get; set; }
        public string? DistrictDescription { get; set; }
        public int CitiId { get; set; }
    }
}
