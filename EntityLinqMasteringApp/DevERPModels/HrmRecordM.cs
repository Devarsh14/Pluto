using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmRecordM
    {
        public long RecordId { get; set; }
        public string RecordName { get; set; }
        public int RecordCategoryId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
