using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlTransactionInspectionM
    {
        public long TransactionInspectionId { get; set; }
        public long MaterialTransactionId { get; set; }
        public int MaterialId { get; set; }
        public string SerialNum { get; set; }
        public double SampleQtyInSkunit { get; set; }
        public short SampleQtySkunitId { get; set; }
        public bool Result { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte Mode { get; set; }
        public long IdealTransactionInspectionId { get; set; }
        public string Notes { get; set; }
        public int InspectedByEmpId { get; set; }
    }
}
