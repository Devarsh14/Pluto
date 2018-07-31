using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAlertGroupIndisciplines
    {
        public short AlertGroupIndisciplineTypeId { get; set; }
        public short AlertGroupId { get; set; }
        public short IndisciplineTypeId { get; set; }
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
