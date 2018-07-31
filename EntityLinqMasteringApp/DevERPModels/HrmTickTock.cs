using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmTickTock
    {
        public long TickTockId { get; set; }
        public long EmployeeId { get; set; }
        public DateTime StartTime { get; set; }
        public long TaskId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? EndTime { get; set; }
        public string Note { get; set; }
    }
}
