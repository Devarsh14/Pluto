using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            PredefinedProductAttributeValue = new HashSet<PredefinedProductAttributeValue>();
            ProductProductAttributeMapping = new HashSet<ProductProductAttributeMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<PredefinedProductAttributeValue> PredefinedProductAttributeValue { get; set; }
        public ICollection<ProductProductAttributeMapping> ProductProductAttributeMapping { get; set; }
    }
}
