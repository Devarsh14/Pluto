using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmSalaryFieldConfig
    {
        public int SalaryFieldConfigId { get; set; }
        public string Field { get; set; }
        public short CellAddressX { get; set; }
        public string CellAddressY { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
