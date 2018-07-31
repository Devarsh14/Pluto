using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderPos
    {
        public long WorkOrderPoid { get; set; }
        public int WorkOrderGroupId { get; set; }
        public int Poid { get; set; }
        public int PoitemId { get; set; }
        public int PriorityForRejection { get; set; }
        public double? PoitemQtyInPoaunit { get; set; }
        public double? PoitemQtyInSkunit { get; set; }
        public double? TargetQtyInPoaunit { get; set; }
        public double? TargetQtyInSkunit { get; set; }
        public double? WorkOrderQtyInPoaunit { get; set; }
        public double? WorkOrderQtyInSkunit { get; set; }
        public double? WorkOrderQtyInProductionQtyUnit { get; set; }
        public double? QtyInProcessInPoaunit { get; set; }
        public double? QtyInProcessInSkunit { get; set; }
        public double? QtyInProcessInProductionQtyUnit { get; set; }
        public double? RejectedQtyInPoaunit { get; set; }
        public double? RejectedQtyInSkunit { get; set; }
        public double? RejectedQtyInProductionQtyUnit { get; set; }
        public double? LowProductionQtyInPoaunit { get; set; }
        public double? LowProductionQtyInSkunit { get; set; }
        public double? LowProductionQtyInProductionQtyUnit { get; set; }
        public double? CompletedQtyInPoaunit { get; set; }
        public double? CompletedQtyInSkunit { get; set; }
        public double? CompletedQtyInProductionQtyUnit { get; set; }
        public double? ReceivedInStoreQtyInPoaunit { get; set; }
        public double? ReceivedInStoreQtyInSkunit { get; set; }
        public double? ReceivedInStoreQtyInProductionQtyUnit { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
