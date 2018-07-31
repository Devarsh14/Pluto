using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeLeaveTypes
    {
        public int EmployeeLeaveTypeId { get; set; }
        public short EmployeeId { get; set; }
        public short LeaveTypeId { get; set; }
        public bool? AllowNegativeBalance { get; set; }
        public short? MaxBackDaysForLeaveRequest { get; set; }
        public double? TotalAddedLeaves { get; set; }
        public double? TotalUsedLeaves { get; set; }
        public double? CurrentUnusedLeaves { get; set; }
        public double? CurrentBookedLeaves { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
