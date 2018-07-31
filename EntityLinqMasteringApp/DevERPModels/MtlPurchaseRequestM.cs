using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPurchaseRequestM
    {
        public int MaterialPurchaseReqId { get; set; }
        public long PrslipNo { get; set; }
        public double TotalAmount { get; set; }
        public double TotalAmountDefaultCurrency { get; set; }
        public int Status { get; set; }
        public string Notes { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
