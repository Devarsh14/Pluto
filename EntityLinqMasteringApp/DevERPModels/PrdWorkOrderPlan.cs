using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderPlan
    {
        public long WorkOrderPlanId { get; set; }
        public long WorkOrderProcessId { get; set; }
        public long WorkOrderId { get; set; }
        public short ProcessStepId { get; set; }
        public short WoprocessOrder { get; set; }
        public int ExpProcessTimeMinutes { get; set; }
        public int Qty { get; set; }
        public DateTime? ExpArrDt { get; set; }
        public DateTime? ExpStartDt { get; set; }
        public DateTime? ExpCloseDt { get; set; }
        public bool HasStarted { get; set; }
        public bool IsPlanned { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPrimary { get; set; }
        public byte Priority { get; set; }
        public bool Waiting { get; set; }
        public DateTime? JobStartDt { get; set; }
        public int MachineId { get; set; }
    }
}
