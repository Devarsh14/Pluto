using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActInvoiceD
    {
        public long InvoiceDetId { get; set; }
        public long InvoiceId { get; set; }
        public long PoitemId { get; set; }
        public long? DeliveryChallanId { get; set; }
        public long? DeliveryChallanDetId { get; set; }
        public long? MaterialId { get; set; }
        public long? ServiceId { get; set; }
        public int? SkuUnitId { get; set; }
        public int? SalesDeliveryUnitUnitId { get; set; }
        public double? SalesDeliveryUnitQty { get; set; }
        public double Quantity { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
        public string Pcbdesc { get; set; }
        public string PackageDesc { get; set; }
        public string CartonNum { get; set; }
        public string NoOfBoxes { get; set; }
        public bool IsAutoNumber { get; set; }
        public string Charge1Name { get; set; }
        public string Charge2Name { get; set; }
        public string Charge3Name { get; set; }
        public string Charge4Name { get; set; }
        public double FixedCharge1 { get; set; }
        public double FixedCharge2 { get; set; }
        public double FixedCharge3 { get; set; }
        public double? FixedCharge4 { get; set; }
        public int PackedQty { get; set; }
        public DateTime? LastPackedDt { get; set; }
        public double Discount { get; set; }
        public double Mrp { get; set; }
        public double Mrpamount { get; set; }
    }
}
