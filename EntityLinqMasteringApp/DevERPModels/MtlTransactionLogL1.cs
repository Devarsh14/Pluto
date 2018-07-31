using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlTransactionLogL1
    {
        public long TransactionLogL1id { get; set; }
        public int MaterialCategoryId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public long MaterialId { get; set; }
        public short CompletedTillProcessId { get; set; }
        public bool IsScrap { get; set; }
        public int LocationId { get; set; }
        public DateTime Date { get; set; }
        public string TransactionType { get; set; }
        public int TransactionTypeId { get; set; }
        public double OpeningQty { get; set; }
        public double Qty { get; set; }
        public double ClosingQty { get; set; }
        public double EmployeeId { get; set; }
        public long ProductId { get; set; }
    }
}
