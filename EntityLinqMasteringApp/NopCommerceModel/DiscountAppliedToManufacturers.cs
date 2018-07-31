using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class DiscountAppliedToManufacturers
    {
        public int DiscountId { get; set; }
        public int ManufacturerId { get; set; }

        public Discount Discount { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
