using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyContactPersonD
    {
        public int CompanyContactPersonId { get; set; }
        public int CompanyId { get; set; }
        public byte? PersonTitleId { get; set; }
        public string PersonTitle { get; set; }
        public string PersonName { get; set; }
        public string Designation { get; set; }
        public string MobileNoDialingCode { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? CompanyAddressDetailId { get; set; }
    }
}
