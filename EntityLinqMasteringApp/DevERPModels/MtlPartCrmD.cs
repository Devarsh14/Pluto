using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPartCrmD
    {
        public long PartCrmid { get; set; }
        public long MaterialId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconImage { get; set; }
        public string ProductImage1 { get; set; }
        public string ProductImage2 { get; set; }
        public string ProductImage3 { get; set; }
        public string ProductImage4 { get; set; }
        public string ProductImage5 { get; set; }
        public double StandardPrice { get; set; }
        public bool ApplicablePriceList { get; set; }
        public int IsOnlineAvailability { get; set; }
        public int IsStockSensitivity { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int SetId { get; set; }
        public string FileName { get; set; }
        public string DisplayFileName { get; set; }
    }
}
