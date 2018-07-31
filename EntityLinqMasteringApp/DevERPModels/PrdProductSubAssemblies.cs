using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductSubAssemblies
    {
        public long ProductSubAssemblyId { get; set; }
        public long MaterialId { get; set; }
        public long SubAssemblyId { get; set; }
        public long SubAssemblySubcategoryId { get; set; }
        public int SubAssemblyCategoryId { get; set; }
        public int ProcessStepId { get; set; }
        public double RequiredSubAssemblyQtyNumerator { get; set; }
        public short RequiredSubAssemblyQtyNumeratorUnitId { get; set; }
        public double RequiredSubAssemblyQtyDenominator { get; set; }
        public short RequiredSubAssemblyQtyDenominatorUnitId { get; set; }
        public bool IsLaunchOrderInParallel { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
