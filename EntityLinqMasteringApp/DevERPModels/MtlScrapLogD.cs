using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlScrapLogD
    {
        public int MaterialScrapId { get; set; }
        public int MaterialId { get; set; }
        public long? BrandId { get; set; }
        public string BatchNo { get; set; }
        public long? BatchNoMaterialTransactionId { get; set; }
        public double StockQty { get; set; }
        public double OpeningScrapQty { get; set; }
        public double ScrapQty { get; set; }
        public double ClosingScrapQty { get; set; }
        public string Notes { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public double OpeningQty { get; set; }
        public double ClosingQty { get; set; }
        public string TransactionType { get; set; }
        public int TransactionTypeId { get; set; }
        public int CompletedTillProcessId { get; set; }
    }
}
