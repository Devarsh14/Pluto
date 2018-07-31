using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AstRepairTypeM
    {
        public int RepairTypeId { get; set; }
        public string RepairTypeName { get; set; }
        public int InchargeEmployeeId { get; set; }
        public string InchargeEmailId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? LedgerId { get; set; }
    }
}
