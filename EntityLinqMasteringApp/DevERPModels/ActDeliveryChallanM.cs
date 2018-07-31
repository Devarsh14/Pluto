using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActDeliveryChallanM
    {
        public long DeliveryChallanId { get; set; }
        public string DeliveryChallanNum { get; set; }
        public string PackingListNum { get; set; }
        public int? ActDeliverySerialNum { get; set; }
        public int CustomerId { get; set; }
        public DateTime DeliveryChallanDate { get; set; }
        public double GrandTotal { get; set; }
        public double GrandTotalInDefaultCurrency { get; set; }
        public int? ShipperId { get; set; }
        public string GoodsDispatchedFrom { get; set; }
        public string TransportMode { get; set; }
        public string TransportModeDetails { get; set; }
        public string PaymentMode { get; set; }
        public DateTime RemovalofGoodsDt { get; set; }
        public double GrossWeight { get; set; }
        public double NetWeight { get; set; }
        public int NoOfBoxes { get; set; }
        public string BoxType { get; set; }
        public int BoxWeight { get; set; }
        public string PreCarriagePlace { get; set; }
        public string CustomerSBankName { get; set; }
        public string PaymentTerms { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime? DeliveryReceiveDt { get; set; }
        public string Poinfo { get; set; }
        public string Remarks { get; set; }
        public bool? IsRoundoff { get; set; }
        public int PlantId { get; set; }
        public int? CurrencyId { get; set; }
        public int? DefaultCurrencyId { get; set; }
        public double? CurrentConversionRate { get; set; }
        public string TrackingNumDelivery { get; set; }
        public bool? IsDirectDeliveryDispatch { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsInvoiceComplete { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
        public int AddressTypeId { get; set; }
        public int ContactId { get; set; }
    }
}
