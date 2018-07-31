using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyDeliveryD
    {
        public long DeliveryId { get; set; }
        public int CompanyId { get; set; }
        public int ShipperId { get; set; }
        public int ShippingModeId { get; set; }
        public int ShippingPeriodInDays { get; set; }
        public double ShippingCost { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
