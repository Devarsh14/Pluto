using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeRecordD
    {
        public int EmployeeRecordDetailId { get; set; }
        public int EmployeeRecordId { get; set; }
        public int RecordFieldId { get; set; }
        public string RecordFieldValue { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
