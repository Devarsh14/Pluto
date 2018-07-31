using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class DiscountRequirement
    {
        public int Id { get; set; }
        public int DiscountId { get; set; }
        public string DiscountRequirementRuleSystemName { get; set; }

        public Discount Discount { get; set; }
    }
}
