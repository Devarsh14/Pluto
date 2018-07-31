using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderGroupM
    {
        public long WorkOrderGroupId { get; set; }
        public int? CustomerId { get; set; }
        public int ProductId { get; set; }
        public short? VersionNum { get; set; }
        public long? ParentWorkOrderGroupId { get; set; }
        public string CustomersForSearch { get; set; }
        public string CustomersToShow { get; set; }
        public short? PoaunitId { get; set; }
        public short? SkunitId { get; set; }
        public short? ReportingUnitId { get; set; }
        public short? ProductionQtyUnitId { get; set; }
        public double? WorkOrderQtyInPoaunit { get; set; }
        public double? WorkOrderQtyInSkunit { get; set; }
        public double? WorkOrderQtyInProductionQtyUnit { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double? WorkOrderQtyInReportingUnitOld { get; set; }
    }
}
