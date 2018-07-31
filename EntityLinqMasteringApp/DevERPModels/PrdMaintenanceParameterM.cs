using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdMaintenanceParameterM
    {
        public short MaintenanceParameterId { get; set; }
        public string MaintenanceParameterName { get; set; }
        public string MaintenanceParameterDisplayName { get; set; }
        public short ParameterTypeId { get; set; }
        public short ParameterOrder { get; set; }
        public string MaintenanceParameterDescription { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
