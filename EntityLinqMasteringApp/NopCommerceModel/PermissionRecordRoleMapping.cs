using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class PermissionRecordRoleMapping
    {
        public int PermissionRecordId { get; set; }
        public int CustomerRoleId { get; set; }

        public CustomerRole CustomerRole { get; set; }
        public PermissionRecord PermissionRecord { get; set; }
    }
}
