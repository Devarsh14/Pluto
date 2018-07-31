using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlDumpM
    {
        public int MaterialDumpId { get; set; }
        public int MaterialId { get; set; }
        public string BatchNo { get; set; }
        public long? BatchNoMaterialTransactionId { get; set; }
        public double StockQty { get; set; }
        public double DumpQty { get; set; }
        public long? BrandId { get; set; }
        public string BatchNoQty { get; set; }
        public string Notes { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
    }
}
