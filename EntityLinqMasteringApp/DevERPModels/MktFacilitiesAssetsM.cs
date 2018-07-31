using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktFacilitiesAssetsM
    {
        public int FacilityAssetId { get; set; }
        public int AssetCategoryId { get; set; }
        public int AssetTypeId { get; set; }
        public int AssetId { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public bool IsShowMake { get; set; }
        public bool IsShowCount { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
