using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderD
    {
        public long WorkOrderDetId { get; set; }
        public long WorkOrderId { get; set; }
        public short ProcessStepId { get; set; }
        public short OutputTypeId { get; set; }
        public int? OutputTypeCauseEmployeeId { get; set; }
        public int? OutputTypeCauseMachineId { get; set; }
        public int? OutputTypeCauseMaterialId { get; set; }
        public short? RemedyId { get; set; }
        public DateTime? RemedyActionDt { get; set; }
        public short RespProcessStepId { get; set; }
        public double? QtyInSkunit { get; set; }
        public double? QtyInProductionQtyUnit { get; set; }
        public double? QtyInReportingUnit { get; set; }
        public double? QtyInProcessOptunit { get; set; }
        public DateTime JobStartDt { get; set; }
        public short? JobStartUserId { get; set; }
        public DateTime? JobCompleteDt { get; set; }
        public short? JobCompleteUserId { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
