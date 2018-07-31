using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlReceiveD
    {
        public int MaterialReceiveDetailId { get; set; }
        public int MaterialReceiveId { get; set; }
        public int MaterialPodetailId { get; set; }
        public int MaterialId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public double ReceivedQty { get; set; }
        public double AccepetedQty { get; set; }
        public double PricePerUnit { get; set; }
        public int? SupplierId { get; set; }
        public short? CurrencyId { get; set; }
        public double ReceivedTotal { get; set; }
        public double? TotalAmount { get; set; }
        public double ReceivedTotalDefaultCurrency { get; set; }
        public double QualityRating { get; set; }
        public int ProcessGroupId { get; set; }
        public string OtherProcessGroupName { get; set; }
        public string BatchNo { get; set; }
        public int? BrandId { get; set; }
        public double? PendingQty { get; set; }
        public double? RejectedQty { get; set; }
        public double? ReceivedQtySku { get; set; }
        public double? AccepetedQtySku { get; set; }
        public double? PendingQtySku { get; set; }
        public double? RejectedQtySku { get; set; }
        public string Notes { get; set; }
        public string RejectionNotes { get; set; }
        public int CompletedTillProcessId { get; set; }
        public int WorkOrderId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
