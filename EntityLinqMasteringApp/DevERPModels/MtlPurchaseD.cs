using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPurchaseD
    {
        public int MaterialPodetailId { get; set; }
        public int MaterialPurchaseReqDetId { get; set; }
        public int MaterialPoid { get; set; }
        public int? MktPoitemId { get; set; }
        public int? MaterialCategoryId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int MaterialId { get; set; }
        public int? MaterialBrandId { get; set; }
        public bool? IsShipToCustomer { get; set; }
        public double? ShippedQty { get; set; }
        public double? RejectedQty { get; set; }
        public double OrderQty { get; set; }
        public string TrackingNo { get; set; }
        public string BatchNo { get; set; }
        public string DeliveryRecordNo { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public double PurchaseReceiptUnitQty { get; set; }
        public double PricePerUnit { get; set; }
        public decimal TotalAmt { get; set; }
        public double TotalAmtDefaultCurrency { get; set; }
        public int? SupplierId { get; set; }
        public int ShipperId { get; set; }
        public int ModeId { get; set; }
        public short? CurrencyId { get; set; }
        public DateTime NeededBy { get; set; }
        public DateTime? EstimateTargetDt { get; set; }
        public int ProcessGroupId { get; set; }
        public string OtherProcessGroupName { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public short? StatusOptionId { get; set; }
    }
}
