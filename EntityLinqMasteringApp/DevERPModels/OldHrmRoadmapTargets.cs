using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmRoadmapTargets
    {
        public int RoadmapTargetId { get; set; }
        public int EmpTargetId { get; set; }
        public int RoadmapStepId { get; set; }
        public byte Necessity { get; set; }
        public int? PercentRole { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
