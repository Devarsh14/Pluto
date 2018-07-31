using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmTrainingObjectivesD
    {
        public int ObjectiveId { get; set; }
        public int TrainingId { get; set; }
        public string Title { get; set; }
        public int SkillId { get; set; }
        public int LevelId { get; set; }
        public bool IsServed { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
