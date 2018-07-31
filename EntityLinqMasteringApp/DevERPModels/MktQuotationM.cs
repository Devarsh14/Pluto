using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktQuotationM
    {
        public long QuotationId { get; set; }
        public int CustomerId { get; set; }
        public string QuotationNum { get; set; }
        public DateTime QuotationDt { get; set; }
        public DateTime ValidTillDt { get; set; }
        public double? TotalAmount { get; set; }
        public byte CurrencyId { get; set; }
        public double? TotalAmountWithTax { get; set; }
        public double? PackingAmount { get; set; }
        public double? DeliveryAmount { get; set; }
        public double DevelopmentCharge { get; set; }
        public double OtherCharge { get; set; }
        public double? TotalAmountBeforeDiscount { get; set; }
        public double? Discount { get; set; }
        public double? TotalFinalAmount { get; set; }
        public string Notes { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public bool? IsFinalized { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public byte? DeliveryPeriod { get; set; }
        public string Period { get; set; }
        public int QtSerialNum { get; set; }
        public int DefaultCurrencyId { get; set; }
        public bool IsDeleted { get; set; }
        public string AddressTo { get; set; }
        public string Subject { get; set; }
        public string Price { get; set; }
        public double PrototypeQuantity { get; set; }
        public string PrototypeQuantityPeriod { get; set; }
        public double ProductionQuantity { get; set; }
        public string ProductionQuantityPeriod { get; set; }
        public bool IsNew { get; set; }
        public string OtherTerms { get; set; }
        public string QuoteVersion { get; set; }
        public double? AppliedMaxDecimalPoints { get; set; }
        public double ProposedRate { get; set; }
        public byte? ExciseId { get; set; }
        public byte? SaleTaxId { get; set; }
        public string QuotationType { get; set; }
        public string FinalCharge1Name { get; set; }
        public double? FinalCharge1Value { get; set; }
        public string FinalCharge2Name { get; set; }
        public double? FinalCharge2Value { get; set; }
        public string FinalCharge3Name { get; set; }
        public double? FinalCharge3Value { get; set; }
        public string FinalCharge4Name { get; set; }
        public double? FinalCharge4Value { get; set; }
        public int PrecisionDigitsRate { get; set; }
        public int AddressTypeId { get; set; }
        public int ContactId { get; set; }
        public string TaxType { get; set; }
    }
}
