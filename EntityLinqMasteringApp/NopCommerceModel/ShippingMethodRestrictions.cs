using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ShippingMethodRestrictions
    {
        public int ShippingMethodId { get; set; }
        public int CountryId { get; set; }

        public Country Country { get; set; }
        public ShippingMethod ShippingMethod { get; set; }
    }
}
