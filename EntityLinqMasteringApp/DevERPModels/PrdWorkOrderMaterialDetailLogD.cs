using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderMaterialDetailLogD
    {
        public long WomaterialDetailLogId { get; set; }
        public long WorkOrderMaterialDetId { get; set; }
        public long WorkOrderId { get; set; }
        public int MaterialId { get; set; }
        public short BrandId { get; set; }
        public long BatchNoId { get; set; }
        public double IssuedQty { get; set; }
        public double UsedQty { get; set; }
        public double ProductionQty { get; set; }
        public double ReceivedInStoreQty { get; set; }
        public double TransferredToOtherJobQty { get; set; }
        public double? ReceivedFromOtherJobQty { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int MaterialIssueDetailId { get; set; }
        public double Rate { get; set; }
    }
}
