using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPartTypes
    {
        public short PartTypeOrder { get; set; }
        public short PartTypeId { get; set; }
        public string PartTypeName { get; set; }
        public bool? IsSoldAsStdProduct { get; set; }
        public bool? IsSoldAsCustomProduct { get; set; }
        public bool? IsSoldAsSpareAccessoryItem { get; set; }
        public bool? IsSoldAsSideScrapItem { get; set; }
        public bool? IsConsumedInProduction { get; set; }
        public bool? IsConsumedInGeneral { get; set; }
        public bool? IsManufacturedInHouse { get; set; }
        public bool? IsPurchaseFromOutsideSuppliers { get; set; }
        public bool? IsReceivedFromProductionAsByproduct { get; set; }
        public bool? IsGeneratedAsScrap { get; set; }
        public bool? IsLocked { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsService { get; set; }
    }
}
