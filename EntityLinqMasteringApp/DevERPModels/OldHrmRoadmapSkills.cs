using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmRoadmapSkills
    {
        public int RoadmapSkillId { get; set; }
        public int RoadmapStepId { get; set; }
        public int SkillId { get; set; }
        public int LevelNeeded { get; set; }
        public byte Necessity { get; set; }
        public int? PercentValue { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
