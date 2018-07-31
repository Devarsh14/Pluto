using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlReturnM
    {
        public int MaterialReturnId { get; set; }
        public int? MaterialReturnMId { get; set; }
        public int MaterialId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int MaterialTypeId { get; set; }
        public double ReturnQty { get; set; }
        public double ReturnPrice { get; set; }
        public int ReturneeId { get; set; }
        public long? WorkOrderId { get; set; }
        public int ProcessGroupId { get; set; }
        public int ProcessStepId { get; set; }
        public int? BrandId { get; set; }
        public string BatchNo { get; set; }
        public long? BatchNoMaterialTransactionId { get; set; }
        public string BatchNoQty { get; set; }
        public string Notes { get; set; }
        public bool IsProvidedByCust { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
    }
}
