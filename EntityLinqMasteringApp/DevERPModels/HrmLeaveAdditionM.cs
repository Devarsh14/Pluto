using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmLeaveAdditionM
    {
        public int EmployeeLeaveAdditionId { get; set; }
        public short EmployeeId { get; set; }
        public short LeaveTypeId { get; set; }
        public double AddedLeaves { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public short? UpdatedUserIdOld { get; set; }
        public DateTime? UpdatedDtOld { get; set; }
        public short? DesignationIdOld { get; set; }
        public double? OpeningBalanceOld { get; set; }
        public double? BalanceOld { get; set; }
        public DateTime EffectiveDt { get; set; }
    }
}
