using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmLeaveTransactionD
    {
        public int LeaveTransactionDetId { get; set; }
        public int EmployeeId { get; set; }
        public short LeaveTypeId { get; set; }
        public DateTime? Date { get; set; }
        public string LeaveTransactionType { get; set; }
        public int? EmployeeLeaveAdditionId { get; set; }
        public long? AttendanceId { get; set; }
        public int? LeaveRequestId { get; set; }
        public double? OpeningUnusedLeaves { get; set; }
        public double? LeaveDays { get; set; }
        public double? ClosingUnusedLeave { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public int? LeaveTransactionIdOld { get; set; }
        public double? AdditionOld { get; set; }
        public double? SubtractionOld { get; set; }
        public double? BalanceOld { get; set; }
    }
}
