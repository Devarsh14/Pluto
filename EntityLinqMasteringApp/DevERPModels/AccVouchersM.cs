using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVouchersM
    {
        public long VoucherId { get; set; }
        public int VoucherTypeId { get; set; }
        public string VoucherFullNum { get; set; }
        public string InvoiceNum { get; set; }
        public int? VoucherNum { get; set; }
        public DateTime VoucherDate { get; set; }
        public DateTime? ReconciliationDate { get; set; }
        public string Description { get; set; }
        public bool EntrySourceErp { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool? IsApproved { get; set; }
        public short? ApprovedUserId { get; set; }
        public DateTime? ApprovedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? ReconciledUserId { get; set; }
        public DateTime? ReconciledDt { get; set; }
        public string BillNum { get; set; }
        public DateTime? PlanDate { get; set; }
        public DateTime? PaymentDueDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsSchedulePayment { get; set; }
        public long? InvoiceId { get; set; }
        public int? MaterialReceiveId { get; set; }
        public int? PaymentId { get; set; }
        public int? PaymentSendId { get; set; }
        public int? MachineRepairId { get; set; }
        public int? MaintainanceId { get; set; }
        public long? CustomerReturnId { get; set; }
        public long? ServiceInvoiceId { get; set; }
        public long? ScrapInvoiceId { get; set; }
        public bool IsSynched { get; set; }
        public long? ChildVoucherId { get; set; }
        public bool? IsReplaced { get; set; }
        public DateTime? InvoiceDt { get; set; }
        public string ChequeName { get; set; }
        public int TransactionId { get; set; }
    }
}
