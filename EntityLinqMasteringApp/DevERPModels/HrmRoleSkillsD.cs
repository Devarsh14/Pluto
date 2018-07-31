using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmRoleSkillsD
    {
        public short RoleSkillDetId { get; set; }
        public int SkillId { get; set; }
        public short RoleId { get; set; }
        public int? DepartmentId { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
