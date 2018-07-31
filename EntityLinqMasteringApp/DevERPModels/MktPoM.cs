using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktPoM
    {
        public long Poid { get; set; }
        public string Ponum { get; set; }
        public int CustomerId { get; set; }
        public string PofileName { get; set; }
        public long? QuotationId { get; set; }
        public double? TotalAmount { get; set; }
        public byte? CurrencyId { get; set; }
        public double? TotalAmountWithTax { get; set; }
        public double? PackingAmount { get; set; }
        public double? DeliveryAmount { get; set; }
        public double? TotalAmountBeforeDiscount { get; set; }
        public double? Discount { get; set; }
        public double? TotalFinalAmount { get; set; }
        public string Notes { get; set; }
        public DateTime Podate { get; set; }
        public int PaymentDueInDays { get; set; }
        public string CustPonum { get; set; }
        public string FinalCharge1Name { get; set; }
        public double? FinalCharge1Value { get; set; }
        public string FinalCharge2Name { get; set; }
        public double? FinalCharge2Value { get; set; }
        public string FinalCharge3Name { get; set; }
        public double? FinalCharge3Value { get; set; }
        public string FinalCharge4Name { get; set; }
        public double? FinalCharge4Value { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? AcceptedUserId { get; set; }
        public DateTime? AcceptedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFinalized { get; set; }
        public bool IsRejected { get; set; }
        public string ReasonToReject { get; set; }
        public double? AppliedMaxDecimalPoints { get; set; }
        public double? LatestCurrencyExchangeRate { get; set; }
        public double? TotalFinalAmountInRs { get; set; }
        public double SubTotal { get; set; }
        public double AssessableValue { get; set; }
        public int ExciseTaxId { get; set; }
        public double ExciseStructAmt { get; set; }
        public double TotalExciseDutyTax { get; set; }
        public string OtherChargesName { get; set; }
        public double? OtherChargesValue { get; set; }
        public double TotalAfterTax { get; set; }
        public int SaleTaxId { get; set; }
        public double TotalSaleDutyTax { get; set; }
        public double FreightAfterTax { get; set; }
        public decimal PoadvanceAmt { get; set; }
        public int PoaSerialNum { get; set; }
        public int DefaultCurrencyId { get; set; }
        public bool? IsLocked { get; set; }
        public int? InvoiceId { get; set; }
        public int AddressTypeId { get; set; }
        public int ContactId { get; set; }
        public bool IsOnlineOrder { get; set; }
        public string TaxType { get; set; }
        public int CreditTo { get; set; }
    }
}
