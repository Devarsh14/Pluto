using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstAssetAllocationM
    {
        public int AssetAllocationId { get; set; }
        public int AssetId { get; set; }
        public int CurrentLocationId { get; set; }
        public int NewLocationId { get; set; }
        public int CurrectInChargeId { get; set; }
        public int NewInChargeId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
