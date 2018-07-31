using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeSkillD
    {
        public long EmployeeSkillDetlId { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }
        public byte? Interest { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
