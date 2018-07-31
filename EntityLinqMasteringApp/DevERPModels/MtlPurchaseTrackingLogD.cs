using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPurchaseTrackingLogD
    {
        public int MaterialPurchaseTrackingLogId { get; set; }
        public int MaterialPodetailId { get; set; }
        public short StatusOptionId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
