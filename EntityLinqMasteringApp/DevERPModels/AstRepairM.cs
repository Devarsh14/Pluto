using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstRepairM
    {
        public int MachineRepairId { get; set; }
        public int AssetCategoryId { get; set; }
        public int MachineId { get; set; }
        public int RepairTypeId { get; set; }
        public double Cost { get; set; }
        public string NoofHoursForRepair { get; set; }
        public int AttendedEmployeeId { get; set; }
        public string Notes { get; set; }
        public int? SupplierId { get; set; }
        public int? RepairRequestId { get; set; }
        public DateTime CompletionDt { get; set; }
        public double ExchangeRate { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPaid { get; set; }
        public int PaidUsingLedgerId { get; set; }
        public long VoucherId { get; set; }
        public bool IsSynched { get; set; }
    }
}
