using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlIssueD
    {
        public int MaterialIssueDetailId { get; set; }
        public int MaterialIssueId { get; set; }
        public int? MaterialIssueReqDetId { get; set; }
        public int MaterialCategoryId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int MaterialId { get; set; }
        public short CompletedTillProcessId { get; set; }
        public int EmployeeId { get; set; }
        public int ProcessGroupId { get; set; }
        public int ProcessStepId { get; set; }
        public int? ProductId { get; set; }
        public double RequestedQty { get; set; }
        public long? WorkOrderId { get; set; }
        public string JobNum { get; set; }
        public string BatchNo { get; set; }
        public long? BatchNoMaterialTransactionId { get; set; }
        public int? BrandId { get; set; }
        public double? IssuedQty { get; set; }
        public string BatchNoQty { get; set; }
        public double? MaterialInUsedQty { get; set; }
        public DateTime NeededOn { get; set; }
        public bool IsProvidedByCust { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
