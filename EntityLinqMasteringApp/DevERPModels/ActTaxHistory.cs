using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActTaxHistory
    {
        public int TaxHistoryId { get; set; }
        public int InvoiceId { get; set; }
        public int MaterialPurchaseReqId { get; set; }
        public int ScrapInvoiceId { get; set; }
        public int TaxStructureId { get; set; }
        public double? Amount { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
