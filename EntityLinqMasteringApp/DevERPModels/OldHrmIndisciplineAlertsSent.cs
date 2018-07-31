using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmIndisciplineAlertsSent
    {
        public long IndisciplineAlertsSentId { get; set; }
        public long EmpIndisciplineId { get; set; }
        public int EmployeeId { get; set; }
        public long? EmailId { get; set; }
        public long? MessageId { get; set; }
        public bool IsViewRecordTo { get; set; }
        public bool IsSendEmailAlertTo { get; set; }
        public bool IsSendSmsalertTo { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
