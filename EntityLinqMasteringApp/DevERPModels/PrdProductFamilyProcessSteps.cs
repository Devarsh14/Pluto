using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductFamilyProcessSteps
    {
        public int ProductFamilyProcessStepId { get; set; }
        public long SubCategoryId { get; set; }
        public int ProcessStepId { get; set; }
        public int ProcessFlowOrder { get; set; }
        public int? ExpMaterialCategoryId { get; set; }
        public long? ExpMaterialSubCategoryId { get; set; }
        public bool IsFinishedProcessOutPut { get; set; }
        public double? ExpProcessOutputQtyNumerator { get; set; }
        public short? ExpProcessOutputQtyUnitIdNumerator { get; set; }
        public double? ExpFinalOutputQtyDenominator { get; set; }
        public short? ExpFinalOutputQtyUnitIdDenominator { get; set; }
        public string InspectionPolicy { get; set; }
        public double? MaximumRejectionAllowPercentage { get; set; }
        public double DefaultInventoryRatePercentage { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsRequireRawMaterial { get; set; }
        public bool? IsRequireSubAssembly { get; set; }
        public bool? IsGenerateByproduct { get; set; }
        public byte? InspectionStyle { get; set; }
    }
}
