using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderMaterialRecoverD
    {
        public long WorkOrderMaterialRecoverDetId { get; set; }
        public short WorkOrderId { get; set; }
        public short ProcessStepId { get; set; }
        public int MaterialId { get; set; }
        public int IssueUnitId { get; set; }
        public double IssueQty { get; set; }
        public double RecoverQty { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
