using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVoucherFormatM
    {
        public int FormatId { get; set; }
        public int VoucherTypeId { get; set; }
        public string FormatStyle { get; set; }
        public string FormatName { get; set; }
        public bool AskForPaymentDetail { get; set; }
        public string AllowPaymentSchedule { get; set; }
        public bool AskForApplyPmtSchedule { get; set; }
        public bool IsLock { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool ExpectInvoiceDetail { get; set; }
    }
}
