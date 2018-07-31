using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstInsuranceAssetM
    {
        public int InsuranceAssetId { get; set; }
        public int InsuranceDetailId { get; set; }
        public int InsuranceId { get; set; }
        public int MachineId { get; set; }
        public double Amount { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
