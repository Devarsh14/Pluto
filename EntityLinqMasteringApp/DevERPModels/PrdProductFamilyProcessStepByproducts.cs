using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductFamilyProcessStepByproducts
    {
        public int ProductFamilyProcessStepByproductId { get; set; }
        public int ProductFamilyProcessStepId { get; set; }
        public long SubCategoryId { get; set; }
        public int ProcessStepId { get; set; }
        public int MaterialCategoryId { get; set; }
        public long MaterialSubCategoryId { get; set; }
        public long MaterialId { get; set; }
        public double? QtyNumerator { get; set; }
        public short? QtyNumeratorUnitId { get; set; }
        public double? QtyDenominator { get; set; }
        public short? QtyDenominatorUnitId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
