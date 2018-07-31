using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccVoucherItemD
    {
        public long VoucherItemDetId { get; set; }
        public long VoucherId { get; set; }
        public long? VoucherDetId { get; set; }
        public int? MaterialReceiveDetailId { get; set; }
        public long? InvoiceDetId { get; set; }
        public string VoucherItem { get; set; }
        public double Quantity { get; set; }
        public decimal Rate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double? Amount { get; set; }
        public long? LedgerId { get; set; }
        public int? OriginalLedgerId { get; set; }
    }
}
