using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class CustomerAttributeValue
    {
        public int Id { get; set; }
        public int CustomerAttributeId { get; set; }
        public string Name { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }

        public CustomerAttribute CustomerAttribute { get; set; }
    }
}
