using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmTrainingSkillsD
    {
        public int TrainingSkillId { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }
        public int TrainingId { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
