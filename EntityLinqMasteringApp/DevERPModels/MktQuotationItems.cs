using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktQuotationItems
    {
        public long Rfqid { get; set; }
        public int? CustomerId { get; set; }
        public string CustomerPartNum { get; set; }
        public string CustomerPartName { get; set; }
        public string GerberFileName { get; set; }
        public int? CustomerQuantity { get; set; }
        public long? QuotationId { get; set; }
        public int? ProductId { get; set; }
        public int ReferenceRfqid { get; set; }
        public short? VersionNum { get; set; }
        public double? Rate { get; set; }
        public double? Amount { get; set; }
        public bool IsEnteredInProductM { get; set; }
        public bool IsQuoted { get; set; }
        public short? RfquserId { get; set; }
        public DateTime? Rfqdt { get; set; }
        public short? QuotationUserId { get; set; }
        public DateTime? QuotationDt { get; set; }
        public DateTime? ValidTillDt { get; set; }
        public string Rfqnum { get; set; }
        public string CustRfqnum { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public string DeliveryLot { get; set; }
        public double QuantityPerLot { get; set; }
        public bool? IsVisible { get; set; }
        public string Charge1Name { get; set; }
        public double? Charge1Value { get; set; }
        public string Charge2Name { get; set; }
        public double? Charge2Value { get; set; }
        public string Charge3Name { get; set; }
        public double? Charge3Value { get; set; }
        public string Charge4Name { get; set; }
        public double? Charge4Value { get; set; }
        public int? PoaunitId { get; set; }
        public int? SkunitId { get; set; }
        public int? RuunitId { get; set; }
        public double? QtyInPoaunitId { get; set; }
        public double? QtyInSkUnitId { get; set; }
        public double? QtyInRuunitId { get; set; }
        public double? CfPoaunitIdToSkunitIdNumerator { get; set; }
        public double? CfPoaunitIdToSkunitIdDenominator { get; set; }
        public int FirstDeliveryAfterDays { get; set; }
        public byte ApplyFixCharges { get; set; }
        public bool IsDeleted { get; set; }
        public double? Quantity { get; set; }
        public string DetailString { get; set; }
        public double? Pcbsize { get; set; }
        public double? PrototypeCharges { get; set; }
        public double? PrototypeDevelopmentCharges { get; set; }
        public short? PcbsPerArray { get; set; }
        public double? GrossPcbwidth { get; set; }
        public double? GrossPcblength { get; set; }
        public double? Pcbwidth { get; set; }
        public double? Pcblength { get; set; }
        public short? GrossPcbunitId { get; set; }
        public short? PcbrateUnitId { get; set; }
        public bool? IsGrossSize { get; set; }
        public string TechDetails { get; set; }
        public double? SetupCharge { get; set; }
        public double? DevelopmentCharges { get; set; }
        public double? OtherCharges { get; set; }
        public bool? IsIgnored { get; set; }
        public double Mrp { get; set; }
        public double Mrpamount { get; set; }
    }
}
