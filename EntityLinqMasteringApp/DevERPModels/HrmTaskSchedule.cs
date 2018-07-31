using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmTaskSchedule
    {
        public long TaskScheduleId { get; set; }
        public long TaskId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public long CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public long UpdatedUserId { get; set; }
    }
}
