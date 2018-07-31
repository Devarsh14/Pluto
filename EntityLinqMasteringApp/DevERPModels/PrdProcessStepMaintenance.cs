using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessStepMaintenance
    {
        public short ProcessStepMaintenanceId { get; set; }
        public short ProcessStepId { get; set; }
        public short MaintenanceTypeId { get; set; }
        public byte MaintenanceBase { get; set; }
        public int? MaintenanceDays { get; set; }
        public int? MaintenanceJobs { get; set; }
        public double? MaintenanceOnOutputUnit { get; set; }
        public double? MaintenanceOnParentUnit { get; set; }
        public DateTime? NextMaintenanceDt { get; set; }
        public int? DoneJobs { get; set; }
        public double? DoneOutputUnit { get; set; }
        public double? DoneParentUnit { get; set; }
        public short? MaintenanceOutputUnitId { get; set; }
        public short? MaintenancePratentUnitId { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsReqParameterReading { get; set; }
        public short? MaintenanceHours { get; set; }
        public short? DoneHours { get; set; }
        public DateTime? NextMaintenanceDtWithHours { get; set; }
    }
}
