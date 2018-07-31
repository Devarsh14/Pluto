using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldOldActPaymentSendD
    {
        public int PaymentSendDetId { get; set; }
        public int? PaymentSendId { get; set; }
        public double Amount { get; set; }
        public int? CurrencyId { get; set; }
        public int PurchaseRequestId { get; set; }
        public bool HasUsedAdvance { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentDetail { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
