using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlReconcileM
    {
        public long MaterialTransactionDetId { get; set; }
        public long MaterialId { get; set; }
        public int BrandId { get; set; }
        public string BatchNo { get; set; }
        public long BatchNoMaterialTransactionId { get; set; }
        public string BatchNoQty { get; set; }
        public double AddedQty { get; set; }
        public double SubtractQty { get; set; }
        public double BalanceQty { get; set; }
        public string Reason { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CompletedTillProcessId { get; set; }
        public bool IsSynched { get; set; }
    }
}
