using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyShipping
    {
        public int CompanyShippingId { get; set; }
        public int CompanyId { get; set; }
        public int? ModeOfTransportId { get; set; }
        public string ShippingMode { get; set; }
        public int ShippingPeriod { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
