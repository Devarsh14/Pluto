using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProductProcessFlow
    {
        public long ProductProcessFlowId { get; set; }
        public long MaterialId { get; set; }
        public int ProcessStepId { get; set; }
        public bool IsSelected { get; set; }
        public bool IsChangeable { get; set; }
        public short ProcessFlowOrder { get; set; }
        public byte ComplexityLevelId { get; set; }
        public byte SetupTimeHours { get; set; }
        public byte SetupTimeMinutes { get; set; }
        public byte MinimumTimeHours { get; set; }
        public byte MinimumTimeMinutes { get; set; }
        public double QtyProductionUnitVariableTime1 { get; set; }
        public short ProductionUnitIdVariableTime1 { get; set; }
        public short ProcessingTimeValueVariableTime1 { get; set; }
        public short TimeUnitIdVariableTime1 { get; set; }
        public int OutputMaterialId { get; set; }
        public bool IsFinishedProcessOutPut { get; set; }
        public double DefaultInventoryRate { get; set; }
        public double? ExpProcessOutputQtyNumerator { get; set; }
        public short? ExpProcessOutputQtyUnitIdNumerator { get; set; }
        public double? ExpFinalOutputQtyDenominator { get; set; }
        public short? ExpFinalOutputQtyUnitIdDenominator { get; set; }
        public short? OutputUnitId { get; set; }
        public short? ProcessOutputUnitId { get; set; }
        public double? CfOptmtlSkunitIdToProcessOptunitIdNumerator { get; set; }
        public double? CfOptmtlSkunitIdToProcessOptunitIdDenominator { get; set; }
        public short? ProcessReportingUnitId { get; set; }
        public double? CfOutPutUnitIdToReportingUnitIdNumerator { get; set; }
        public double? CfOutPutUnitIdToReportingUnitIdDenominator { get; set; }
        public string InspectionPolicy { get; set; }
        public double? MaximumRejectionAllowPercentage { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public short? RejectionUnitId { get; set; }
        public double? QtyProductionUnitVariableTime2 { get; set; }
        public short? ProductionUnitIdVariableTime2 { get; set; }
        public short? ProcessingTimeValueVariableTime2 { get; set; }
        public short? TimeUnitIdVariableTime2 { get; set; }
        public bool? IsOutsourcePossible { get; set; }
        public byte? SendTo { get; set; }
        public short? LocationId { get; set; }
        public double Costing { get; set; }
    }
}
