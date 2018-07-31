using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstSupplierOfferingM
    {
        public int OfferingId { get; set; }
        public int AssetCategoryId { get; set; }
        public int MachineTypeId { get; set; }
        public int SupplierId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
