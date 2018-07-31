using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstRepairRequestM
    {
        public int RepairRequestId { get; set; }
        public int AssetCategoryId { get; set; }
        public int MachineTypeId { get; set; }
        public int MachineId { get; set; }
        public int RepairTypeId { get; set; }
        public string Repair { get; set; }
        public double? ExpectedCost { get; set; }
        public string ExpectedHoursForRepair { get; set; }
        public byte? Status { get; set; }
        public int? ApprovedEmployeeId { get; set; }
        public DateTime? ApprovedDt { get; set; }
        public int? Incharge { get; set; }
        public bool? IsCompleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
