using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstMaintenance
    {
        public int MachineMaintenanceId { get; set; }
        public int MachineId { get; set; }
        public string MaintenanceTypeName { get; set; }
        public double? MaintenancePeriodInOutputUnit { get; set; }
        public int? MaintenancePeriodInOutputUnitId { get; set; }
        public double? MaintenancePeriodInReportingUnit { get; set; }
        public int? MaintenancePeriodInReportingUnitId { get; set; }
        public int? MaintenancePeriodNoOfJobs { get; set; }
        public int? MaintenancePeriodOfDays { get; set; }
        public double? NextMaintenanceInOutputUnit { get; set; }
        public double? NextMaintenanceInReportingUnit { get; set; }
        public int? NextMaintenanceForJobs { get; set; }
        public DateTime? NextMaintenanceDt { get; set; }
        public double? OutputCount { get; set; }
        public double? ReportingCount { get; set; }
        public int? JobCount { get; set; }
        public int? DayCount { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? MaintenanceComplete { get; set; }
        public short? MaintenanceCompletUserId { get; set; }
        public bool IsCompleteMaintenance { get; set; }
        public int? MaintenanceTypeId { get; set; }
        public string AlertSmsnumbersMachineMaintenance { get; set; }
        public int? MaintenancePeriodNoOfPcbs { get; set; }
        public byte MaintenanceBase { get; set; }
        public short? MaintenancePeriodInNoOfHours { get; set; }
        public short? NextMaintenancePeriodAfterNoOfHours { get; set; }
        public DateTime? NextMaintenanceDtWithHours { get; set; }
    }
}
