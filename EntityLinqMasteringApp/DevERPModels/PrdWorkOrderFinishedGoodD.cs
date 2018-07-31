using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderFinishedGoodD
    {
        public long WorkOrderFinishedGoodDetId { get; set; }
        public long WorkOrderId { get; set; }
        public long? ProductId { get; set; }
        public short CompletedTillProcessId { get; set; }
        public bool IsSemiProcessed { get; set; }
        public short? StoreLocationId { get; set; }
        public short? LocationId { get; set; }
        public double? FinishedGoodsQty { get; set; }
        public short? FinishedGoodsQtyUnitId { get; set; }
        public double? FinishedGoodsQtyInPoaunit { get; set; }
        public double? FinishedGoodsQtyInProductionQtyUnit { get; set; }
        public double? FinishedGoodsQtyInSkunit { get; set; }
        public double? FinishedGoodsQtyInProcessOptunit { get; set; }
        public double? FinishedGoodsQtyInProcessReportingUnit { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
        public double? FinishedGoodsQtyInReportingUnitIdOld { get; set; }
    }
}
