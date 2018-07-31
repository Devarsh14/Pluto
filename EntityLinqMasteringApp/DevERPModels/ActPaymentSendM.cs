using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPaymentSendM
    {
        public int PaymentSendId { get; set; }
        public string PaymentSendNum { get; set; }
        public int SupplierId { get; set; }
        public double OpeningAdvance { get; set; }
        public bool HasUsedAdvance { get; set; }
        public double ClosingAdvance { get; set; }
        public byte PaymentTypeId { get; set; }
        public string PaymentDetail { get; set; }
        public int PaymentSendLedgerId { get; set; }
        public double TotalPaidAmt { get; set; }
        public double TotalPaidAmtDefaultCurr { get; set; }
        public byte CurrencyId { get; set; }
        public byte DefaultCurrencyId { get; set; }
        public double ExchangeConversionRate { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPaidAdvance { get; set; }
        public long VoucherId { get; set; }
        public bool IsSynched { get; set; }
    }
}
