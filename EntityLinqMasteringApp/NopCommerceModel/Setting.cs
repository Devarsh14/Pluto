using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int StoreId { get; set; }
    }
}
