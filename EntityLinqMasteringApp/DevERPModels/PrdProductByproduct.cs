using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductByproduct
    {
        public long ProductByproductId { get; set; }
        public long MaterialId { get; set; }
        public long ByproductId { get; set; }
        public long ByproductSubcategoryId { get; set; }
        public int ByproductCategoryId { get; set; }
        public int ProcessStepId { get; set; }
        public double RequiredByproductQtyNumerator { get; set; }
        public short RequiredByproductQtyNumeratorUnitId { get; set; }
        public double RequiredByproductQtyDenominator { get; set; }
        public short RequiredByproductQtyDenominatorUnitId { get; set; }
        public byte? SendTo { get; set; }
        public short? LocationId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
