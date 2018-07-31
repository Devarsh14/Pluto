using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductFamilyProcessStepCapacityD
    {
        public int ProductFamilyProcessStepCapacityId { get; set; }
        public int ProductFamilyProcessStepId { get; set; }
        public long SubCategoryId { get; set; }
        public int ProcessStepId { get; set; }
        public byte ComplexityLevelId { get; set; }
        public short SetupTimeHrs { get; set; }
        public short SetupTimeMins { get; set; }
        public short MinTimeHrs { get; set; }
        public short MinTimeMins { get; set; }
        public double ProductionCapacity { get; set; }
        public short ProductionUnitId { get; set; }
        public double? ProductionCapacityDenominator { get; set; }
        public short? ProductionUnitIdDenominator { get; set; }
        public double? ReportingUnitCapacity { get; set; }
        public short? ReportingUnitId { get; set; }
        public double? ReportingUnitCapacityDenominator { get; set; }
        public short? ReportingUnitIdDenominator { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
