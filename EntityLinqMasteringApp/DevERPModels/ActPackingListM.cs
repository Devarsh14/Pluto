using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActPackingListM
    {
        public long PackingListId { get; set; }
        public string PackingListNum { get; set; }
        public string Notes { get; set; }
        public string PortofDischarge { get; set; }
        public string PortofLoading { get; set; }
        public string CountryofOrigin { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryAddress { get; set; }
        public string FinalDestination { get; set; }
        public string PreCarriagePlace { get; set; }
        public string DeliveryTerms { get; set; }
        public string PaymentTerms { get; set; }
        public short TransportModeId { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryCountry1 { get; set; }
        public string DeliveryPinCode { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
