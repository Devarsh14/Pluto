using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmSkillAdditionRecord
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public short? CategoryId { get; set; }
        public short SkillId { get; set; }
        public int LevelId { get; set; }
        public string AdditionType { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string Description { get; set; }
    }
}
