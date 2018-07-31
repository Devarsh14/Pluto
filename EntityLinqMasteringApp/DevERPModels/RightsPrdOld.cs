﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsPrdOld
    {
        public int PrdrightsId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public string DefaultPage { get; set; }
        public bool FullAccess { get; set; }
        public bool JobScheduling { get; set; }
        public bool ShowCustomer { get; set; }
        public bool ShowCustomerDetail { get; set; }
        public bool ShowPodetail { get; set; }
        public bool JobList { get; set; }
        public bool ChangePriority { get; set; }
        public bool ChangeScheduling { get; set; }
        public bool DeleteScheduledUnstartedJob { get; set; }
        public bool ViewListOfPendingJobList { get; set; }
        public bool ViewListOfQueueJobList { get; set; }
        public bool ViewListOfUnStartedJobList { get; set; }
        public bool ViewListOfFutureJobList { get; set; }
        public bool ViewListOfPausedJobList { get; set; }
        public bool ViewListOfCompletedJobList { get; set; }
        public bool ViewProcesswiseWorkLoad { get; set; }
        public bool ProcessAccessibility { get; set; }
        public bool FullProcessAccess { get; set; }
        public bool SelectiveProcessAccess { get; set; }
        public bool NoProcessAccess { get; set; }
        public bool JobDetails { get; set; }
        public bool JobCard { get; set; }
        public bool SetPlannedCompletionDate { get; set; }
        public bool StartJob { get; set; }
        public bool CloseJob { get; set; }
        public bool QuickClose { get; set; }
        public bool JumpTo { get; set; }
        public bool PauseAndResumeJob { get; set; }
        public bool InspectQuality { get; set; }
        public bool GroupClose { get; set; }
        public bool ProcessEntry { get; set; }
        public bool ViewListOfProcessGroups { get; set; }
        public bool CreateProcessGroupEntry { get; set; }
        public bool DeleteProcessGroupEntry { get; set; }
        public bool ViewListOfProcesses { get; set; }
        public bool CreateProcessEntry { get; set; }
        public bool UpdateProcessEntry { get; set; }
        public bool DeleteProcessEntry { get; set; }
        public bool PartEntry { get; set; }
        public bool CreatePartEntry { get; set; }
        public bool EditPartEntry { get; set; }
        public bool DeletePartEntry { get; set; }
        public bool PartEntryWithMultipleCustomers { get; set; }
        public bool EditProcessFlowInPartEntry { get; set; }
        public bool EditPanelInPartEntry { get; set; }
        public bool EditCharacteristicsInPartEntry { get; set; }
        public bool FileManagementForParts { get; set; }
        public bool AddFiles { get; set; }
        public bool ChangeExistingFiles { get; set; }
        public bool ViewFiles { get; set; }
        public bool PanelManagement { get; set; }
        public bool ViewListOfPanelRequirement { get; set; }
        public bool SheetCutting { get; set; }
        public bool PrdConfiguration { get; set; }
        public bool PrdOtherConfiguration { get; set; }
        public bool ConfigurationProductionPlanning { get; set; }
        public bool FailureType { get; set; }
        public bool ViewListOfFailureTypes { get; set; }
        public bool CreateFailureType { get; set; }
        public bool EditFailureType { get; set; }
        public bool DeleteFailureType { get; set; }
        public bool Remedies { get; set; }
        public bool ViewListOfRemedies { get; set; }
        public bool CreateRemedies { get; set; }
        public bool EditRemedies { get; set; }
        public bool DeleteRemedies { get; set; }
        public bool InactiveJobs { get; set; }
        public bool ViewListOfInactiveJobs { get; set; }
        public bool DeleteInactiveJob { get; set; }
        public bool PrdReports { get; set; }
        public bool ViewProductionTargets { get; set; }
        public bool EditProductionTargets { get; set; }
        public bool ViewProductionVolume { get; set; }
        public bool ViewProductionEfficiency { get; set; }
        public bool ViewPrdProcessEfficiency { get; set; }
        public bool ViewPrdProcessEfficiencyInDetail { get; set; }
        public bool ViewDailyProductionOutput { get; set; }
        public bool ViewPrdWorkSequence { get; set; }
        public bool ViewPrdRemedialActions { get; set; }
        public bool ViewProductionPerformance { get; set; }
        public bool ViewPrdProcessPerformance { get; set; }
        public bool ViewPrdProcessCapacityUtilizationSummary { get; set; }
        public bool ViewPrdProcessCapacityUtilization { get; set; }
        public bool ViewPrdRejectionRecords { get; set; }
        public bool ViewPrdProcesswiseRejectionAnalysis { get; set; }
        public bool ViewPrdRejectionDetailsForProcess { get; set; }
        public bool ViewPrdProcesswiseRejectionList { get; set; }
        public bool ViewPrdProcesswiseRejectionTrend { get; set; }
        public bool ViewPrdRejectionTrendForProcess { get; set; }
        public bool ViewPrdProductTypewiseOutputEfficiency { get; set; }
        public bool ViewPrdJobwiseOutputEfficiency { get; set; }
        public bool ViewPrdProcesswiseOutputEfficiency { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? ProductionDashboard { get; set; }
        public short? ProcessGroupId { get; set; }
        public bool? IsShowInfoOfOtherDept { get; set; }
        public bool AllowUpdatePartDefAfterLocking { get; set; }
    }
}