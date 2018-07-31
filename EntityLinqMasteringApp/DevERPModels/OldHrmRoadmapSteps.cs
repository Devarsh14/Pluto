using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmRoadmapSteps
    {
        public int RoadmapStepId { get; set; }
        public int EmployeeId { get; set; }
        public int DesignationId { get; set; }
        public byte IncrementLevel { get; set; }
        public int SalaryAmt { get; set; }
        public DateTime TargetDt { get; set; }
        public DateTime? AchievedDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatdUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public short TargetsScoreExpected { get; set; }
        public short SkillsScoreExpected { get; set; }
    }
}
