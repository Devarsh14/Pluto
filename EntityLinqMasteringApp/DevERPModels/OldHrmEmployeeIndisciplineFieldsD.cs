using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmEmployeeIndisciplineFieldsD
    {
        public long FieldDetlId { get; set; }
        public long EmpIndisciplineId { get; set; }
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public short CellAddressX { get; set; }
        public string CellAddressY { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
