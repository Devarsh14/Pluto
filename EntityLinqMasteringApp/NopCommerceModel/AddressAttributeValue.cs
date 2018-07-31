using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class AddressAttributeValue
    {
        public int Id { get; set; }
        public int AddressAttributeId { get; set; }
        public string Name { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }

        public AddressAttribute AddressAttribute { get; set; }
    }
}
