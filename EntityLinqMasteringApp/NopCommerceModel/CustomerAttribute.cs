using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class CustomerAttribute
    {
        public CustomerAttribute()
        {
            CustomerAttributeValue = new HashSet<CustomerAttributeValue>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }

        public ICollection<CustomerAttributeValue> CustomerAttributeValue { get; set; }
    }
}
