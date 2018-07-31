using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class DiscountAppliedToCategories
    {
        public int DiscountId { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Discount Discount { get; set; }
    }
}
