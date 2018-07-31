using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmEmployeeTargets
    {
        public int EmpTargetId { get; set; }
        public int TargetTypeId { get; set; }
        public int EmployeeId { get; set; }
        public string Target { get; set; }
        public string Description { get; set; }
        public int FarExceed { get; set; }
        public int Exceed { get; set; }
        public int MeetWith { get; set; }
        public int NotMeetWith { get; set; }
        public int Failure { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
