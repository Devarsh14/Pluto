using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPaymentSendD
    {
        public int PaymentSendDetId { get; set; }
        public int PaymentSendId { get; set; }
        public int MaterialReceiveId { get; set; }
        public bool IsAdvance { get; set; }
        public double PendingAmount { get; set; }
        public double PaidAmount { get; set; }
        public double PaidAmountDefaultCurr { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
