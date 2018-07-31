using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderM
    {
        public long WorkOrderId { get; set; }
        public long WorkOrderGroupId { get; set; }
        public string JobNum { get; set; }
        public string BatchNo { get; set; }
        public string WorkOrderNum { get; set; }
        public int ProductId { get; set; }
        public short VersionNum { get; set; }
        public int? MaterialSubCategoryId { get; set; }
        public byte PlantId { get; set; }
        public string JobType { get; set; }
        public byte Priority { get; set; }
        public long RelaunchWorkOrderId { get; set; }
        public bool IsIgnoredRelaunch { get; set; }
        public string RelaunchReason { get; set; }
        public long ParentWorkOrderGroupId { get; set; }
        public short ParentProcessStepId { get; set; }
        public int AcceptableProcessFlowId { get; set; }
        public short? PoaunitId { get; set; }
        public short? SkunitId { get; set; }
        public double? CfSkunitIdToPoaunitIdNumerator { get; set; }
        public double? CfSkunitIdToPoaunitIdDenominator { get; set; }
        public short? ReportingUnitId { get; set; }
        public double? CfSkunitIdToReportingUnitIdNumerator { get; set; }
        public double? CfSkunitIdToReportingUnitIdDenominator { get; set; }
        public bool? IsProdQtyUnitSameAsSkunit { get; set; }
        public bool? IsRelationExistForSkunitToProdQtyUnit { get; set; }
        public double? WorkOrderQtyInPoaunit { get; set; }
        public double? WorkOrderQtyInSkunit { get; set; }
        public double? WorkOrderQtyInProductionQtyUnit { get; set; }
        public double? WoWarningQtyInPoaunit { get; set; }
        public double? WoWarningQtyInSkunit { get; set; }
        public double? WoWarningQtyInProdQtyUnit { get; set; }
        public short? ProductionQtyUnitId { get; set; }
        public double? CfSkunitIdToProdQtyUnitIdNumerator { get; set; }
        public double? CfSkunitIdToProdQtyUnitIdDenominator { get; set; }
        public double? RejectedQtyInPoaunit { get; set; }
        public double? RejectedQtyInSkunit { get; set; }
        public double? RejectedQtyInProductionQtyUnit { get; set; }
        public double? LowProductionQtyInPoaunit { get; set; }
        public double? LowProductionQtyInSkunit { get; set; }
        public double? LowProductionQtyInProductionQtyUnit { get; set; }
        public double? CompletedQtyInPoaunit { get; set; }
        public double? CompletedQtyInSkunit { get; set; }
        public double? CompletedQtyInProductionQtyUnit { get; set; }
        public double? ReceivedInStoreQtyInPoaunit { get; set; }
        public double? ReceivedInStoreQtyInSkunit { get; set; }
        public double? ReceivedInStoreQtyInProductionQtyUnit { get; set; }
        public DateTime IssuedDt { get; set; }
        public short IssuedUserId { get; set; }
        public DateTime TargetStartDt { get; set; }
        public DateTime TargetComplnDt { get; set; }
        public short CurrentProcessStepId { get; set; }
        public string CurrentProcessStepName { get; set; }
        public string CurrentProcessSteps { get; set; }
        public bool? IsUnStartedWorkOrder { get; set; }
        public bool IsPaused { get; set; }
        public bool? IsInActiveWorkOrder { get; set; }
        public bool? IsCompletedWorkOrder { get; set; }
        public bool IsSentDelayAlert { get; set; }
        public DateTime? ExpStartDt { get; set; }
        public DateTime? ExpCloseDt { get; set; }
        public DateTime? WoStartedDt { get; set; }
        public DateTime? WoFirstCompletedDt { get; set; }
        public DateTime? WoLastCompletedDt { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
        public string RelevantPos { get; set; }
        public double? RelevantPoqty { get; set; }
        public string RelevantPodates { get; set; }
        public DateTime? NewExpCloseDt { get; set; }
        public DateTime? ProposedLaunchDt { get; set; }
        public double? WorkOrderQtyInReportingUnitOld { get; set; }
        public double? RejectedQtyInReportingUnitOld { get; set; }
        public double? LowProductionQtyInReportingUnitOld { get; set; }
        public double? CompletedQtyInReportingUnitOld { get; set; }
        public double? ReceivedInStoreQtyInReportingUnitOld { get; set; }
    }
}
