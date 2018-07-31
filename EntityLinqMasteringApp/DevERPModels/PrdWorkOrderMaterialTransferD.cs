using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderMaterialTransferD
    {
        public long WorkOrderMaterialTransferDetId { get; set; }
        public long WorkOrderMaterialDetId { get; set; }
        public double MaterialTransferredQty { get; set; }
        public short MaterialTransferredQtyUnitId { get; set; }
        public long TransferredToWorkOrderMaterialDetId { get; set; }
        public int? TransferredToProcessStepId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
