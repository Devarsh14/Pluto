﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class PermissionRecord
    {
        public PermissionRecord()
        {
            PermissionRecordRoleMapping = new HashSet<PermissionRecordRoleMapping>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SystemName { get; set; }
        public string Category { get; set; }

        public ICollection<PermissionRecordRoleMapping> PermissionRecordRoleMapping { get; set; }
    }
}
