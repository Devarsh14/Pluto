using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPaymentD
    {
        public long PaymentDetId { get; set; }
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public bool IsAdvance { get; set; }
        public double Amount { get; set; }
        public double? AmountDefaultCurrencyId { get; set; }
        public bool IsDeleted { get; set; }
        public double? TotalFinalAmountInRsOld { get; set; }
    }
}
