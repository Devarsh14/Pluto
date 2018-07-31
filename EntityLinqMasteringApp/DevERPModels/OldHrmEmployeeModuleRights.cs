using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmEmployeeModuleRights
    {
        public int EmployeeRightsId { get; set; }
        public int EmployeeId { get; set; }
        public int EmployeeTypeId { get; set; }
        public string ModuleName { get; set; }
        public bool IsNone { get; set; }
        public bool IsJunior { get; set; }
        public bool IsMedium { get; set; }
        public bool IsSenior { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
