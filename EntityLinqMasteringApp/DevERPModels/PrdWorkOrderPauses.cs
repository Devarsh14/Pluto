using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderPauses
    {
        public long WorkOrderPausesId { get; set; }
        public long WorkOrderId { get; set; }
        public short ProcessStepId { get; set; }
        public DateTime PauseDt { get; set; }
        public short PauseUserId { get; set; }
        public DateTime? ResumeDt { get; set; }
        public short? ResumeUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
