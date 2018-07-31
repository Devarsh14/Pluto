using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlCustomerReturnM
    {
        public long CustomerReturnId { get; set; }
        public string CustomerReturnNum { get; set; }
        public long InvoiceId { get; set; }
        public int? CustomerId { get; set; }
        public string InvoiceNum { get; set; }
        public double SubTotal { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountAmt { get; set; }
        public double? TotalAssessableVal { get; set; }
        public int ExciseId { get; set; }
        public double ExciseDutyPercent { get; set; }
        public double ExciseDutyAmt { get; set; }
        public double PreSalesTaxTotal { get; set; }
        public double FreightBeforeTax { get; set; }
        public double TotalAfterFreight { get; set; }
        public int SalesTaxId { get; set; }
        public double SalesTaxPercent { get; set; }
        public double SalesTaxAmt { get; set; }
        public double FreightAfterTax { get; set; }
        public string OtherChargesName { get; set; }
        public double? OtherChargesValue { get; set; }
        public string PafchargesName { get; set; }
        public double? PafchargesValue { get; set; }
        public double OtherChargesValueAfter { get; set; }
        public double GrandTotal { get; set; }
        public double DutyAmtPayble { get; set; }
        public string Description { get; set; }
        public bool? IsRoundOff { get; set; }
        public int? CurrencyId { get; set; }
        public DateTime? CustomerReturnDt { get; set; }
        public int CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
    }
}
