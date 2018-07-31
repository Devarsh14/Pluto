using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActTaxNewM
    {
        public byte TaxId { get; set; }
        public string TaxType { get; set; }
        public string TaxStrName { get; set; }
        public string TaxName { get; set; }
        public double TaxRate { get; set; }
        public string SubTax1Name { get; set; }
        public double? SubTax1Rate { get; set; }
        public bool? IsSubTax1OnTotal { get; set; }
        public string SubTax2Name { get; set; }
        public double? SubTax2Rate { get; set; }
        public int? LedgerId { get; set; }
        public bool? IsSubTax2OnTotal { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsRefundable { get; set; }
        public int? SubTax1LedgerId { get; set; }
        public int? SubTax2LedgerId { get; set; }
        public int? Applicability { get; set; }
        public int? LedgerIdOut { get; set; }
        public int? SubTax1LedgerIdOut { get; set; }
        public int? SubTax2LedgerIdOut { get; set; }
        public short ClassificationId { get; set; }
        public double EffectiveTax { get; set; }
    }
}
