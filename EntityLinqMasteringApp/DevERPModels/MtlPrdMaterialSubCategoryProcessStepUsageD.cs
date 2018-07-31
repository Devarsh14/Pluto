using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdMaterialSubCategoryProcessStepUsageD
    {
        public long MaterialSubCategoryProcessStepUsageId { get; set; }
        public int MaterialCategoryId { get; set; }
        public long MaterialSubCategoryId { get; set; }
        public long? MaterialId { get; set; }
        public int ProcessStepId { get; set; }
        public short UsageBasisId { get; set; }
        public double UsageQtyNumerator { get; set; }
        public short UsageQtyNumeratorUnitId { get; set; }
        public double UsageQtyDenominator { get; set; }
        public short UsageQtyDenominatorUnitId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
