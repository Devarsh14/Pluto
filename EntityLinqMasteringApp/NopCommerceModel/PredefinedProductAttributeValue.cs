using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class PredefinedProductAttributeValue
    {
        public int Id { get; set; }
        public int ProductAttributeId { get; set; }
        public string Name { get; set; }
        public decimal PriceAdjustment { get; set; }
        public decimal WeightAdjustment { get; set; }
        public decimal Cost { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }

        public ProductAttribute ProductAttribute { get; set; }
    }
}
