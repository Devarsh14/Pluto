using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class ActDeliveryChallanItemD
    {
        public int DeliveryItemId { get; set; }
        public int? DeliveryChallanId { get; set; }
        public string DeliveryBoxName { get; set; }
        public double BoxSizeLength { get; set; }
        public double BoxSizeWidth { get; set; }
        public double BoxSizeHeight { get; set; }
        public string BoxSizeUnit { get; set; }
        public double BoxWeight { get; set; }
        public string BoxWeightUnit { get; set; }
        public double GrossWeight { get; set; }
        public string GrossWeightUnit { get; set; }
        public int Poid { get; set; }
        public int ProductId { get; set; }
        public double? PackedQtyInSkuunit { get; set; }
        public double PackedQty { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
