using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class DiscountAppliedToProducts
    {
        public int DiscountId { get; set; }
        public int ProductId { get; set; }

        public Discount Discount { get; set; }
        public Product Product { get; set; }
    }
}
