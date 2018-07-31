using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlTransactionInspectionD
    {
        public long TransactionInspectionDetailId { get; set; }
        public long TransactionInspectionId { get; set; }
        public int FieldId { get; set; }
        public string FieldValue1 { get; set; }
        public string FieldValue2 { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long IdealTransactionInspectionDetailId { get; set; }
    }
}
