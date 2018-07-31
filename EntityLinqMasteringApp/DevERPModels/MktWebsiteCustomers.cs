using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktWebsiteCustomers
    {
        public int WebsiteCustomerId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public short ReferenceMode { get; set; }
        public short CompanyAddressDetailId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
