using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMtlDeliveryChallanReturnM
    {
        public long DeliveryChallanReturnId { get; set; }
        public int SupplierId { get; set; }
        public double Amount { get; set; }
        public double? ChargeBeforeTax { get; set; }
        public int? ExciseTaxId { get; set; }
        public double? ExciseAmount { get; set; }
        public int? SaleTaxId { get; set; }
        public double? SalesTaxAmount { get; set; }
        public double? ChargeAfterTax { get; set; }
        public double TotalAmount { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
