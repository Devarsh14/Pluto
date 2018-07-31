using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsPrd
    {
        public int PrdrightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public bool FullAccess { get; set; }
        public string DefaultPageTitle { get; set; }
        public bool PrdWorkInProcess { get; set; }
        public bool ShowCustomerPrdWip { get; set; }
        public bool ChangePriorityWo { get; set; }
        public bool ChangeTargetDtWo { get; set; }
        public bool ViewAllDeptPrdWip { get; set; }
        public bool PrintJobCardPrd { get; set; }
        public bool PrdProcessAccessibility { get; set; }
        public bool FullProcessAccess { get; set; }
        public bool SelectiveProcessAccess { get; set; }
        public bool NoProcessAccess { get; set; }
        public bool PrdJobScheduling { get; set; }
        public bool ViewScheduledJob { get; set; }
        public bool ScheduleNewJob { get; set; }
        public bool ChangeScheduledJob { get; set; }
        public bool DeleteUnStartedScheduledJob { get; set; }
        public bool ViewCustomerOrderJobScheduling { get; set; }
        public bool RunAutoSchedulerPrdPpq { get; set; }
        public bool PrdJobMovement { get; set; }
        public bool PrdViewTraveler { get; set; }
        public bool PrdWopPlanMovement { get; set; }
        public bool PrdWoStartJob { get; set; }
        public bool PrdWoCloseJob { get; set; }
        public bool PrdWoPauseResumeJob { get; set; }
        public bool PrdWoEnterQcInspectionData { get; set; }
        public bool PrdProcessMaintenanceParameterReading { get; set; }
        public bool PartSpecificationEntry { get; set; }
        public bool ViewPartPrintable { get; set; }
        public bool CreatePartDraft { get; set; }
        public bool ApprovePartDraft { get; set; }
        public bool UpdatePart { get; set; }
        public bool DeletePart { get; set; }
        public bool PrdMaterialRequest { get; set; }
        public bool PrdAutoApproveMtlrequest { get; set; }
        public bool PrdPanelManagement { get; set; }
        public bool PrdReports { get; set; }
        public bool PerformanceCapacityUtilizationReports { get; set; }
        public bool JobHistoryReports { get; set; }
        public bool RejectionQcAnalysisReports { get; set; }
        public bool PrdSetProductionTargets { get; set; }
        public bool PrdEmailAlerts { get; set; }
        public bool PrdAlertDailyProductionPerformance { get; set; }
        public bool PrdAlertWorkQueue { get; set; }
        public bool PrdRejectionConfiguration { get; set; }
        public bool ReasonsRejectionRework { get; set; }
        public bool Remedies { get; set; }
        public bool PrdProcessConfiguration { get; set; }
        public bool PrdProcesses { get; set; }
        public bool PrdProcessGroups { get; set; }
        public bool ServiceConfiguration { get; set; }
        public bool Services { get; set; }
        public bool ServiceTypes { get; set; }
        public bool ServiceCategories { get; set; }
        public bool PrdOtherConfiguration { get; set; }
        public bool PrdMiscSettings { get; set; }
        public bool PrdJobEstimationSettings { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool ViewCustomerDetail { get; set; }
    }
}
