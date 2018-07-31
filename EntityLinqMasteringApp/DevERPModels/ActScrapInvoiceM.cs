using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActScrapInvoiceM
    {
        public long ScrapInvoiceId { get; set; }
        public int ScrapBuyerId { get; set; }
        public string InvoiceNum { get; set; }
        public double SubTotal { get; set; }
        public double? OtherChargesBeforeTax { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountAmt { get; set; }
        public double? TotalAssessableVal { get; set; }
        public int ExciseId { get; set; }
        public double ExciseDutyPercent { get; set; }
        public double ExciseDutyAmt { get; set; }
        public double PreSalesTaxTotal { get; set; }
        public double FreightBeforeTax { get; set; }
        public double TotalAfterFreight { get; set; }
        public double SalesTaxId { get; set; }
        public double SalesTaxPercent { get; set; }
        public double SalesTaxAmt { get; set; }
        public double FreightAfterTax { get; set; }
        public double? OtherCharges { get; set; }
        public double GrandTotal { get; set; }
        public int? ShipperId { get; set; }
        public int? ShippingModeId { get; set; }
        public string Description { get; set; }
        public bool IsRoundOff { get; set; }
        public int CurrencyId { get; set; }
        public DateTime? ScrapInvoiceDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string OtherChargesBeforeTaxDesc { get; set; }
        public string OtherChargesName { get; set; }
        public bool IsSynched { get; set; }
    }
}
