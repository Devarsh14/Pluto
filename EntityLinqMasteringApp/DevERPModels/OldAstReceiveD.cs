using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldAstReceiveD
    {
        public int AssetReceiveDetailId { get; set; }
        public int AssetReceiveId { get; set; }
        public int AssetPodetailId { get; set; }
        public int MachineTypeId { get; set; }
        public int AssetCategoryId { get; set; }
        public double ReceivedQty { get; set; }
        public double PricePerUnit { get; set; }
        public int? SupplierId { get; set; }
        public short? CurrencyId { get; set; }
        public double ReceivedTotal { get; set; }
        public double? TotalAmount { get; set; }
        public double ReceivedTotalDefaultCurrency { get; set; }
        public double? PendingQty { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
