using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ShippingMethod
    {
        public ShippingMethod()
        {
            ShippingMethodRestrictions = new HashSet<ShippingMethodRestrictions>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<ShippingMethodRestrictions> ShippingMethodRestrictions { get; set; }
    }
}
