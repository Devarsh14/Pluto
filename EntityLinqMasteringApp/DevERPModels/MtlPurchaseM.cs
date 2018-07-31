using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPurchaseM
    {
        public int MaterialPoid { get; set; }
        public string MaterialPonum { get; set; }
        public int PotypeId { get; set; }
        public DateTime Podate { get; set; }
        public string AmdNo { get; set; }
        public DateTime AmdDate { get; set; }
        public double SubTotal { get; set; }
        public double AssessableValue { get; set; }
        public string OtherChargesaName { get; set; }
        public double OtherChargesValue { get; set; }
        public int ExciseTaxId { get; set; }
        public double ExciseStructAmt { get; set; }
        public double TotalAfterExciseDuty { get; set; }
        public double? FreightBeforeTax { get; set; }
        public double? TotalAfterFreightTax { get; set; }
        public int SaleTaxId { get; set; }
        public double SalesStructAmt { get; set; }
        public double TotalAfterSalesTax { get; set; }
        public double GrandTotal { get; set; }
        public double GrandTotalDefaultCurrency { get; set; }
        public int ModeId { get; set; }
        public int ShipperId { get; set; }
        public string PaymentTerms { get; set; }
        public byte Status { get; set; }
        public string Remarks { get; set; }
        public string DisappReason { get; set; }
        public bool IsPaid { get; set; }
        public int MtlPoSerialNum { get; set; }
        public short? DefaultCurrencyId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
    }
}
