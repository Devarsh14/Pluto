using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktCustomerRegn
    {
        public int CustomerRegistrationId { get; set; }
        public string CompanyName { get; set; }
        public short? CustomerCategoryId { get; set; }
        public short? BusinessActivityId { get; set; }
        public short? MarketValueId { get; set; }
        public string CompanyAddress1 { get; set; }
        public string CompanyAddress2 { get; set; }
        public int CompanyCountryId { get; set; }
        public int CompanyStateId { get; set; }
        public int CompanyCityId { get; set; }
        public string CompanyPincode { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPhoneNoDialingCode { get; set; }
        public string CompanyPhoneNo { get; set; }
        public string CompanyFaxDialingCode { get; set; }
        public string CompanyFaxNo { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public int BillingCountryId { get; set; }
        public int BillingStateId { get; set; }
        public int BillingCityId { get; set; }
        public string BillingPincode { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public int DeliveryCountryId { get; set; }
        public int DeliveryStateId { get; set; }
        public int DeliveryCityId { get; set; }
        public string DeliveryPincode { get; set; }
        public string TitleOrganizationHead { get; set; }
        public string OrganizationHead { get; set; }
        public string OrganizationHeadDesignation { get; set; }
        public string OrganizationHeadPhoneNoDialingCode { get; set; }
        public string OrganizationHeadPhoneNo { get; set; }
        public string OrganizationHeadEmail { get; set; }
        public string TitleContactPerson { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonDesignation { get; set; }
        public string ContactPersonPhoneNoDialingCode { get; set; }
        public string ContactPersonPhoneNo { get; set; }
        public string ContactPersonEmail { get; set; }
        public bool IsRegistered { get; set; }
        public bool IsRejected { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
