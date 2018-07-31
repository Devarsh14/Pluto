using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessStepM
    {
        public byte ProcessStepId { get; set; }
        public short ProcessGroupId { get; set; }
        public string ProcessStepName { get; set; }
        public string ProcessStepCode { get; set; }
        public string ProcessStepShortName { get; set; }
        public short ProcessOrder { get; set; }
        public byte WorkHoursPerDayHours { get; set; }
        public byte WorkHoursPerDayMinutes { get; set; }
        public short AllowedNumOfJobs { get; set; }
        public bool IncludeProductionArea { get; set; }
        public bool IsOutSourcePossible { get; set; }
        public bool? IsDifferentRejectionUnit { get; set; }
        public string InspectionQty { get; set; }
        public double? MaxRejectionAllowedPercentage { get; set; }
        public string ProcessFileName { get; set; }
        public string Notes { get; set; }
        public string Psn { get; set; }
        public short? PollingId { get; set; }
        public short? ProductionInputUnitCategoryId { get; set; }
        public short? ProductionInputUnitId { get; set; }
        public short? ProductionOutputUnitCategoryId { get; set; }
        public short? ProductionOutputUnitId { get; set; }
        public short? ReportingUnitCategoryId { get; set; }
        public short? ReportingUnitId { get; set; }
        public bool? IsReportingUnitEqualsOutputUnit { get; set; }
        public bool? IsRelationExist { get; set; }
        public double? CfOutPutUnitIdToReportingUnitIdNumerator { get; set; }
        public double? CfOutPutUnitIdToReportingUnitIdDenominator { get; set; }
        public bool? BubbleAlert { get; set; }
        public bool? IsBubbleAlertPossible { get; set; }
        public short? BubbleCount { get; set; }
        public double? BubbleAvgTime { get; set; }
        public int? BubbleMaxSize { get; set; }
        public bool? IsSplitJobforMl { get; set; }
        public bool? IsApplicableSpeedFactor { get; set; }
        public int? MaxPartPerday { get; set; }
        public bool? IsCompletedUnit { get; set; }
        public bool? IsCompletedTiming { get; set; }
        public bool? IsCompletedRawMaterial { get; set; }
        public bool? IsCompletedByProduct { get; set; }
        public bool? IsCompletedMachine { get; set; }
        public bool? IsCompletedRejection { get; set; }
        public bool? IsCompletedAlert { get; set; }
        public bool? IsCompletedMaintenance { get; set; }
        public double TargetOutputQtyPerDay { get; set; }
        public double TargetOutputQty { get; set; }
        public string TargetOutputUnit { get; set; }
        public double TargetRejectionQtyPerDay { get; set; }
        public double TargetLowProductionQtyPerDay { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte? ProductionInputUnitIdFrom { get; set; }
        public byte? ProductionInputUnitIdTo { get; set; }
        public short? BypassMachinesDeleted { get; set; }
        public short? PcbtypeIdDeleted { get; set; }
        public byte? DepartmentIdDeleted { get; set; }
        public short? ProductionOutputUnitIdFrom { get; set; }
        public short? ProductionOutputUnitIdTo { get; set; }
        public short? ParentUnitCategoryId { get; set; }
        public short? ParentUnitIdFrom { get; set; }
        public short? ParentUnitIdTo { get; set; }
        public string MaintenanceOverDueAlertMobileNo { get; set; }
        public bool IsGenerateByproduct { get; set; }
        public bool? IsReqParameterReading { get; set; }
        public bool IsIncludeInSummaryEmails { get; set; }
        public bool IsOutputUnitEqualsInputUnit { get; set; }
        public bool IsProductionProcess { get; set; }
        public bool IsServiceProcess { get; set; }
        public bool IsRequiredMaintenance { get; set; }
        public bool IsRequiredRawMtls { get; set; }
        public bool IsUsesMachines { get; set; }
    }
}
