using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmRoadmapReviewLog
    {
        public int ReviewLogId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReviewPlanDt { get; set; }
        public DateTime? ReviewCompletionDt { get; set; }
        public int OriginalDesignationId { get; set; }
        public int? NewDesignationId { get; set; }
        public int? OriginalSalaryAmt { get; set; }
        public int? NewSalaryAmt { get; set; }
        public int? DecisionId { get; set; }
        public int? NewReportingToId { get; set; }
        public int? OriginalDepartmentId { get; set; }
        public int? NewDepartmentId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
