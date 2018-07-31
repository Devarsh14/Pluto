using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldAstTaxHistory
    {
        public int TaxHistoryId { get; set; }
        public int AssetPoid { get; set; }
        public int TaxStructureId { get; set; }
        public double? Amount { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
