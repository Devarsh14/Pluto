using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktCustomerRegistrationM
    {
        public int CustomerRegistrationId { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyFax { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyProducts { get; set; }
        public string CompanyProducts2 { get; set; }
        public string CompanyProducts3 { get; set; }
        public string TitleContactPerson { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonDesignation { get; set; }
        public string ContactPersonPhone { get; set; }
        public string ContactPersonEmail { get; set; }
        public bool IsRegistered { get; set; }
        public int RoleId { get; set; }
        public string CustomerCst { get; set; }
        public string CustomerEccnum { get; set; }
        public long CustomerTaxId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte CurrencyId { get; set; }
        public double ExcessQuantityPercent { get; set; }
        public string BillingAddress1 { get; set; }
        public string BillingAddress2 { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingCountry { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryCountry { get; set; }
        public DateTime? Cstdate { get; set; }
        public string BankName { get; set; }
        public string PortOfDischarge { get; set; }
        public string Notes { get; set; }
        public string PinCode { get; set; }
        public string BillingPinCode { get; set; }
        public string DeliveryPinCode { get; set; }
        public double CurrentBalanceAmount { get; set; }
        public DateTime? LastBalanceUpdatedDt { get; set; }
        public short? QuoteStructure { get; set; }
        public string TitleOrganizationHead { get; set; }
        public string OrganizationHead { get; set; }
        public string OrganizationHeadDesignation { get; set; }
        public string OrganizationHeadPhone { get; set; }
        public string OrganizationHeadEmail { get; set; }
        public bool IsRigid { get; set; }
        public bool IsFlexible { get; set; }
        public bool IsSingleSide { get; set; }
        public bool IsDoubleSide { get; set; }
        public bool IsMultiLayerUpto8 { get; set; }
        public bool IsMultiLayer8Up { get; set; }
        public int? PcbusageYear { get; set; }
        public short? BusinessActivityId { get; set; }
        public short? OrderVolume { get; set; }
        public short? TypeOfProductId { get; set; }
        public string CustomerTin { get; set; }
        public DateTime? Tindate { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int CountryId { get; set; }
        public int BillingCityId { get; set; }
        public int BillingStateId { get; set; }
        public int BillingCountryId { get; set; }
        public int DeliveryCityId { get; set; }
        public int DeliveryStateId { get; set; }
        public int DeliveryCountryId { get; set; }
    }
}
