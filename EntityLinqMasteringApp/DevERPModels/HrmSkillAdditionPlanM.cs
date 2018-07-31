using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmSkillAdditionPlanM
    {
        public int SkillAdditionId { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }
        public DateTime Date { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
