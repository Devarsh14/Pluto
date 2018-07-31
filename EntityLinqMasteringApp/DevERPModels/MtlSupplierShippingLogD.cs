using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlSupplierShippingLogD
    {
        public long SupplierShippingLogId { get; set; }
        public int MaterialPodetailId { get; set; }
        public string DeliveryRecordNo { get; set; }
        public DateTime DeliveryRecordDt { get; set; }
        public string TrackingNo { get; set; }
        public int CustomerCompanyId { get; set; }
        public long MaterialId { get; set; }
        public string BatchNo { get; set; }
        public double ShippedQtyInSaleUnit { get; set; }
        public bool IsFullyReceived { get; set; }
        public double? RecievedQtyInSaleUnit { get; set; }
        public double? AcceptedQtyInSaleUnit { get; set; }
        public double? RejectedQtyInSaleUnit { get; set; }
        public double? ShippedQtyInSkunit { get; set; }
        public double? RecievedQtyInSkunit { get; set; }
        public double? AcceptedQtyInSkunit { get; set; }
        public double? RejectedQtyInSkunit { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
