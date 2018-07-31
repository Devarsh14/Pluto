using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class SpecificationAttributeOption
    {
        public SpecificationAttributeOption()
        {
            ProductSpecificationAttributeMapping = new HashSet<ProductSpecificationAttributeMapping>();
        }

        public int Id { get; set; }
        public int SpecificationAttributeId { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public int DisplayOrder { get; set; }

        public SpecificationAttribute SpecificationAttribute { get; set; }
        public ICollection<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMapping { get; set; }
    }
}
