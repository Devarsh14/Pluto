using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeRecordM
    {
        public int EmployeeRecordId { get; set; }
        public int EmployeeId { get; set; }
        public int RecordId { get; set; }
        public DateTime RecordDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsConfidential { get; set; }
    }
}
