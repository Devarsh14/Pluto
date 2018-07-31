using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActInvoiceTaxD
    {
        public long InvoiceTaxId { get; set; }
        public long InvoiceId { get; set; }
        public int TaxId { get; set; }
        public double Rate { get; set; }
        public double Amount { get; set; }
        public double? SubTax1Rate { get; set; }
        public double? SubTax1Amount { get; set; }
        public bool? IsSubTax1OnTotal { get; set; }
        public double? SubTax2Rate { get; set; }
        public double? SubTax2Amount { get; set; }
        public bool? IsSubTax2OnTotal { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedId { get; set; }
        public bool IsDeleted { get; set; }
        public double AppliedOnAmount { get; set; }
    }
}
