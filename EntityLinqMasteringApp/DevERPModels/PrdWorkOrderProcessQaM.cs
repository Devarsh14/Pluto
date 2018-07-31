using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderProcessQaM
    {
        public long WorkOrderProcessQaid { get; set; }
        public long WorkOrderId { get; set; }
        public long WorkOrderProcessId { get; set; }
        public string SerialNum { get; set; }
        public double SampleQtyInSkunit { get; set; }
        public double SampleQtyInProdQtyUnit { get; set; }
        public double SampleQtyInReportingUnit { get; set; }
        public double? SampleQtyInProcessOptunit { get; set; }
        public short SampleQtySkunitId { get; set; }
        public short SampleQtyProdQtyUnitId { get; set; }
        public short SampleQtyReportingUnitId { get; set; }
        public short? SampleQtyProcessOptunitId { get; set; }
        public bool Result { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public long IdealWorkOrderProcessQaid { get; set; }
        public string Notes { get; set; }
        public int InspectedByEmpId { get; set; }
    }
}
