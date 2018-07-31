using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ProductTag
    {
        public ProductTag()
        {
            ProductProductTagMapping = new HashSet<ProductProductTagMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductProductTagMapping> ProductProductTagMapping { get; set; }
    }
}
