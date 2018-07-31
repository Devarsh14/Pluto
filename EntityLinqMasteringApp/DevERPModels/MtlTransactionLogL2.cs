using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlTransactionLogL2
    {
        public long TransactionLogL2id { get; set; }
        public long TransactionLogL1id { get; set; }
        public long TransactionLid { get; set; }
        public int MaterialCategoryId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public long MaterialId { get; set; }
        public string BatchNo { get; set; }
        public long? BatchNoId { get; set; }
        public int BrandId { get; set; }
        public bool IsScrap { get; set; }
        public int LocationId { get; set; }
        public DateTime Date { get; set; }
        public string TransactionType { get; set; }
        public long? TransactionTypeId { get; set; }
        public long? TransactionTypeDetailId { get; set; }
        public double OpeningQty { get; set; }
        public double Qty { get; set; }
        public double ClosingQty { get; set; }
        public double Rate { get; set; }
        public int EmployeeId { get; set; }
        public int CompanyId { get; set; }
        public long ProductId { get; set; }
    }
}
