using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlTransactionRateChanges
    {
        public int TransactionRateChangeId { get; set; }
        public int MaterialTransactionId { get; set; }
        public double NewRate { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
    }
}
