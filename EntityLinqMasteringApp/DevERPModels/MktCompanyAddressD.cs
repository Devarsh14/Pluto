using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCompanyAddressD
    {
        public int CompanyAddressDetailId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyAddressType { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public int CompanyCountryId { get; set; }
        public string CompanyCountry { get; set; }
        public int CompanyStateId { get; set; }
        public string CompanyState { get; set; }
        public int CompanyCityId { get; set; }
        public string CompanyCity { get; set; }
        public string CompanyPincode { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhoneNoDialingCode { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyFaxDialingCode { get; set; }
        public string CompanyFaxNo { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
