using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPaymentTypeM
    {
        public byte PaymentTypeId { get; set; }
        public string PaymentTypeName { get; set; }
        public string DetailDisplayName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
