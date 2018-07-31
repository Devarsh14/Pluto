using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdMaintenanceParameterReadingD
    {
        public long MaintenanceParameterLogDetailId { get; set; }
        public long MaintenanceParameterLogId { get; set; }
        public int MaintenanceParameterDetailsId { get; set; }
        public short ProcessId { get; set; }
        public short MaintenanceParameterId { get; set; }
        public string IdealValue { get; set; }
        public string IdealMinValue { get; set; }
        public string IdealMaxValue { get; set; }
        public string ParameterValueUnitName { get; set; }
        public string ActualValue { get; set; }
        public string Notes { get; set; }
        public byte Result { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
