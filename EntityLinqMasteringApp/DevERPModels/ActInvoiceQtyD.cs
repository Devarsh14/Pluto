using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActInvoiceQtyD
    {
        public int InvoiceQtyId { get; set; }
        public int InvoiceDetId { get; set; }
        public int MaterialId { get; set; }
        public int BrandId { get; set; }
        public string BatchNo { get; set; }
        public double? SalesDeliveryUnitQty { get; set; }
        public double Quantity { get; set; }
        public double? Rate { get; set; }
        public double? Amount { get; set; }
        public DateTime? ExpireDt { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
