using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActDeliveryChallanD
    {
        public long DeliveryChallanDetId { get; set; }
        public long DeliveryChallanId { get; set; }
        public long PoitemId { get; set; }
        public long? MaterialTransactionId { get; set; }
        public int? MaterialId { get; set; }
        public string BatchNo { get; set; }
        public int? BrandId { get; set; }
        public int? SkuUnitId { get; set; }
        public int? SalesDeliveryUnitUnitId { get; set; }
        public double? SalesDeliveryUnitQty { get; set; }
        public double Quantity { get; set; }
        public double? Rate { get; set; }
        public string Pcbdesc { get; set; }
        public string PackageDesc { get; set; }
        public string Charge1Name { get; set; }
        public string Charge2Name { get; set; }
        public string Charge3Name { get; set; }
        public string Charge4Name { get; set; }
        public double? FixedCharges1 { get; set; }
        public double? FixedCharges2 { get; set; }
        public double? FixedCharges3 { get; set; }
        public double? FixedCharges4 { get; set; }
        public double? Amount { get; set; }
        public double? AmountInDefaultCurrency { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
