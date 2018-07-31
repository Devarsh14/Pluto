using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlCustomerReturnD
    {
        public long CustomerReturnDetId { get; set; }
        public long? CustomerReturnId { get; set; }
        public long InvoiceId { get; set; }
        public long MaterialId { get; set; }
        public int SkuunitId { get; set; }
        public int SalesDeliveryUnitId { get; set; }
        public double QtyInSalesDeliveryUnit { get; set; }
        public double QtyInSkunit { get; set; }
        public double? OtherCharges { get; set; }
        public double Rate { get; set; }
        public double TotalAmt { get; set; }
        public int Status { get; set; }
        public bool IsReplace { get; set; }
        public bool IsDeleted { get; set; }
    }
}
