using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActScrapInvoiceD
    {
        public long ScrapInvoiceDetId { get; set; }
        public long ScrapInvoiceId { get; set; }
        public long MaterialId { get; set; }
        public int SalesDeliveryUnitId { get; set; }
        public double SalesDeliveryUnitQty { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double TotalAmt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
