using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstAssetCategoryM
    {
        public int AssetCategoryId { get; set; }
        public int? GroupId { get; set; }
        public string AssetCategoryName { get; set; }
        public string AssetCategoryCode { get; set; }
        public string Description { get; set; }
        public bool AskLocationMovement { get; set; }
        public bool AskWarrantyInsurance { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsMachine { get; set; }
    }
}
