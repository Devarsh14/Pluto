using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventTaskD
    {
        public int TaskId { get; set; }
        public int EventId { get; set; }
        public string TaskName { get; set; }
        public int EmployeeId { get; set; }
        public DateTime TaskDate { get; set; }
        public int ReminderId { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool Status { get; set; }
    }
}
