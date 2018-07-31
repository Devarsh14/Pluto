using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class CustomerRole
    {
        public CustomerRole()
        {
            AclRecord = new HashSet<AclRecord>();
            CustomerCustomerRoleMapping = new HashSet<CustomerCustomerRoleMapping>();
            PermissionRecordRoleMapping = new HashSet<PermissionRecordRoleMapping>();
            TierPrice = new HashSet<TierPrice>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool FreeShipping { get; set; }
        public bool TaxExempt { get; set; }
        public bool Active { get; set; }
        public bool IsSystemRole { get; set; }
        public string SystemName { get; set; }
        public int PurchasedWithProductId { get; set; }

        public ICollection<AclRecord> AclRecord { get; set; }
        public ICollection<CustomerCustomerRoleMapping> CustomerCustomerRoleMapping { get; set; }
        public ICollection<PermissionRecordRoleMapping> PermissionRecordRoleMapping { get; set; }
        public ICollection<TierPrice> TierPrice { get; set; }
    }
}
