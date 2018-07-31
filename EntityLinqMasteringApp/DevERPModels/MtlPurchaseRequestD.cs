using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPurchaseRequestD
    {
        public int MaterialPurchaseReqDetId { get; set; }
        public int MaterialPurchaseReqId { get; set; }
        public int MaterialCategoryId { get; set; }
        public int MaterialId { get; set; }
        public int? MaterialBrandId { get; set; }
        public int? MaterialSubCategoryId { get; set; }
        public double OrderQtyOld { get; set; }
        public double ApproveQtyOld { get; set; }
        public short? PurchaseReceiptUnitUnitId { get; set; }
        public double PurchaseReceiptUnitQtyOld { get; set; }
        public double PricePerUnit { get; set; }
        public decimal Total { get; set; }
        public double TotalDefaultCurrency { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? NeededBy { get; set; }
        public string Status { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public short? CurrencyId { get; set; }
        public string Notes { get; set; }
        public double? RequestedQtyInSkunit { get; set; }
        public double? RequestedQtyInPurchaseReceiptUnit { get; set; }
        public double? ApprovedQtyInSkunit { get; set; }
        public double? ApprovedQtyInPurchaseReceiptUnit { get; set; }
    }
}
