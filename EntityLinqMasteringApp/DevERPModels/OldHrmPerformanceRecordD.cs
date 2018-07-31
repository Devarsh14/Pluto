using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmPerformanceRecordD
    {
        public int EmpPerformanceId { get; set; }
        public int EmployeeId { get; set; }
        public int RecordId { get; set; }
        public DateTime RecordDate { get; set; }
        public string RecordTitle { get; set; }
        public string RecordDescription { get; set; }
        public string CreatedUserName { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}
