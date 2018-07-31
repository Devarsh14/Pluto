using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVouchersD
    {
        public long VoucherDetId { get; set; }
        public long VoucherId { get; set; }
        public int LedgerId { get; set; }
        public decimal CrAmount { get; set; }
        public decimal DbAmount { get; set; }
        public string Description { get; set; }
        public short? TransferModeId { get; set; }
        public string Reference { get; set; }
        public int? InvoiceId { get; set; }
        public string InvoiceNum { get; set; }
        public bool? IsAdvance { get; set; }
        public DateTime? PlanDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsPaid { get; set; }
        public double? PendingAmount { get; set; }
        public byte? TableNum { get; set; }
        public int? OriginalLedgerId { get; set; }
    }
}
