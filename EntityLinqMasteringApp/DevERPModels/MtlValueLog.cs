using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlValueLog
    {
        public int MaterialValueLogId { get; set; }
        public int MaterialId { get; set; }
        public string Form { get; set; }
        public string TransactionType { get; set; }
        public int TransactionTypeId { get; set; }
        public double ClosingBalance { get; set; }
        public double ValueChange { get; set; }
        public DateTime EntryDateTime { get; set; }
        public double CurrentBalance { get; set; }
    }
}
