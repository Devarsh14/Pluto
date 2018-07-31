﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActInvoiceM
    {
        public long InvoiceId { get; set; }
        public string InvoiceNum { get; set; }
        public int? ActInvoiceSerialNum { get; set; }
        public int CustomerId { get; set; }
        public string InvoiceType { get; set; }
        public double SubTotal { get; set; }
        public double DiscountPercent { get; set; }
        public double AssessableTotal { get; set; }
        public double? ExciseDutyPercent { get; set; }
        public double? EduCessPercent { get; set; }
        public double? EduCessShpercent { get; set; }
        public double PreSalesTaxTotal { get; set; }
        public int SalesTaxId { get; set; }
        public double? SalesTaxPercent { get; set; }
        public double Shipping { get; set; }
        public double? Handling { get; set; }
        public double? TcstaxPercent { get; set; }
        public double GrandTotal { get; set; }
        public double DutyAmtPayable { get; set; }
        public string VideDebitEntryNo { get; set; }
        public string PlaregEntry { get; set; }
        public string Rg23 { get; set; }
        public string PartIi { get; set; }
        public string DutyDate { get; set; }
        public DateTime? CustomerCstdate { get; set; }
        public int? ShipperId { get; set; }
        public string GoodsDispatchedFrom { get; set; }
        public string TransportMode { get; set; }
        public string TransportModeDetails { get; set; }
        public string DeliveryChallanNum { get; set; }
        public DateTime? DeliveryChallanDate { get; set; }
        public string PaymentMode { get; set; }
        public byte? Coddays { get; set; }
        public DateTime InvoiceDt { get; set; }
        public DateTime RemovalofGoodsDt { get; set; }
        public double GrossWeight { get; set; }
        public double NetWeight { get; set; }
        public int NoOfBoxes { get; set; }
        public bool IsExport { get; set; }
        public bool IsFob { get; set; }
        public string DispatchDocNo { get; set; }
        public bool? IsDirectDeliveryInvoice { get; set; }
        public DateTime? PaymentDueDt { get; set; }
        public string TrackingNumInvoice { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public DateTime? InvoiceReceiveDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string CentralExciseAgainst { get; set; }
        public double LessAdvance { get; set; }
        public double Insurance { get; set; }
        public string BoxType { get; set; }
        public int BoxWeight { get; set; }
        public string DimensionOfPackage { get; set; }
        public string PortOfLoading { get; set; }
        public string PreCarriagePlace { get; set; }
        public string FinalDestination { get; set; }
        public string PortOfDischarge { get; set; }
        public string CustomerSBankName { get; set; }
        public string ShippingMark { get; set; }
        public string FreightTerms { get; set; }
        public string PaymentTerms { get; set; }
        public string DeliveryTerms { get; set; }
        public string DeliveryAddress { get; set; }
        public byte? CreditDays { get; set; }
        public bool? IsFreightTaxable { get; set; }
        public double AdditionalVatpercent { get; set; }
        public int? ExciseTaxId { get; set; }
        public string OtherChargesName { get; set; }
        public double? OtherChargesValue { get; set; }
        public string ExporterRefNum { get; set; }
        public string ConsigneeRefNum { get; set; }
        public string OtherChargesBeforeTaxDesc { get; set; }
        public double? OtherChargesBeforeTaxAmt { get; set; }
        public DateTime? PlaregEntryDate { get; set; }
        public DateTime? Rg23entryDate { get; set; }
        public string Poinfo { get; set; }
        public string Remarks { get; set; }
        public double? FrightBeforeTax { get; set; }
        public bool? IsRoundoff { get; set; }
        public double TotalReceivedAmount { get; set; }
        public double? TotalReceivedAmountInRs { get; set; }
        public DateTime? LastAmountReceivedDt { get; set; }
        public bool IsFullyPaid { get; set; }
        public int PlantId { get; set; }
        public string ShippingTerm { get; set; }
        public double? CurrentConversionRate { get; set; }
        public double? TotalFinalAmountInRs { get; set; }
        public int? CurrencyId { get; set; }
        public int? DefaultCurrencyId { get; set; }
        public bool? IsSez { get; set; }
        public string Ofnno { get; set; }
        public string DeliveryAddress1 { get; set; }
        public string DeliveryAddress2 { get; set; }
        public string DeliveryCity { get; set; }
        public string DeliveryState { get; set; }
        public string DeliveryCountry { get; set; }
        public string DeliveryPinCode { get; set; }
        public string TaxType { get; set; }
        public string QuotationNum { get; set; }
        public long VoucherId { get; set; }
        public bool IsSynched { get; set; }
        public int AddressTypeId { get; set; }
        public int ContactId { get; set; }
        public double DiscountAmt { get; set; }
        public string Type { get; set; }
        public int ReceiptSupplierId { get; set; }
        public int CreaditTo { get; set; }
    }
}