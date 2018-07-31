using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktQuotationTaxes
    {
        public long QuotationTaxId { get; set; }
        public long QuotationId { get; set; }
        public long TaxId { get; set; }
        public double TaxPercent { get; set; }
        public double TaxAmount { get; set; }
        public bool? IsDeleted { get; set; }
        public double AppliedOnAmount { get; set; }
        public double SubTax1Rate { get; set; }
        public double SubTax1Amount { get; set; }
        public bool IsSubTax1OnTotal { get; set; }
        public double SubTax2Rate { get; set; }
        public double SubTax2Amount { get; set; }
        public bool IsSubTax2OnTotal { get; set; }
    }
}
