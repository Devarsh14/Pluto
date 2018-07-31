using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderProcessQaIdealM
    {
        public long IdealWorkOrderProcessQaid { get; set; }
        public long WorkOrderId { get; set; }
        public long WorkOrderProcessId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
