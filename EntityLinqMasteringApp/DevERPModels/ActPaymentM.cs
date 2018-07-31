using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPaymentM
    {
        public int PaymentId { get; set; }
        public string PaymentReceiptNum { get; set; }
        public int CustomerId { get; set; }
        public double OpeningAdvance { get; set; }
        public bool HasUsedAdvance { get; set; }
        public double ClosingAdvance { get; set; }
        public bool? IsPaymentReceivedFromInvoice { get; set; }
        public byte PaymentTypeId { get; set; }
        public string PaymentDetail { get; set; }
        public int PaymentReceiveLedgerId { get; set; }
        public double? TotalAmount { get; set; }
        public double? TotalAmountDefaultCurrencyId { get; set; }
        public byte CurrencyId { get; set; }
        public byte DefaultCurrencyId { get; set; }
        public double? CurrentConversionRate { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double AmountForAdvanceOld { get; set; }
        public double? TotalFinalAmountInRsOld { get; set; }
        public long VoucherId { get; set; }
        public bool IsSynched { get; set; }
    }
}
