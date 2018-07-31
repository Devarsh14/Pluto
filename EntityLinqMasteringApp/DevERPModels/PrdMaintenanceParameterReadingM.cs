using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdMaintenanceParameterReadingM
    {
        public long MaintenanceParameterLogId { get; set; }
        public DateTime ObservationDt { get; set; }
        public short ObservedByEmpId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
