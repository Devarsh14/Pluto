using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderMachineD
    {
        public long WorkOrderMachineDetId { get; set; }
        public long WorkOrderId { get; set; }
        public int ProcessStepId { get; set; }
        public long? WorkOrderDetId { get; set; }
        public int MachineId { get; set; }
        public double? MachineUsageInProcessOutputUnit { get; set; }
        public double? WorkDoneQtyInProductionQtyUnit { get; set; }
        public double? WorkDoneQtyInSkunit { get; set; }
        public double? WorkDoneQtyInReportingUnit { get; set; }
        public double? RoleInPercentage { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
