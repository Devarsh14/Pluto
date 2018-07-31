using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmProjectTeam
    {
        public long ProjectTeamId { get; set; }
        public long ProjectId { get; set; }
        public long EmployeeId { get; set; }
        public int Access { get; set; }
        public long CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public long? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
