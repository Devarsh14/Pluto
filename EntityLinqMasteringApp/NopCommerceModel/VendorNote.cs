using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class VendorNote
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public string Note { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public Vendor Vendor { get; set; }
    }
}
