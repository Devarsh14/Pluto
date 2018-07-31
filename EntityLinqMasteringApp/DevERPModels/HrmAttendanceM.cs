using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmAttendanceM
    {
        public long AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime IdealInTime { get; set; }
        public byte? AttendanceStatusId { get; set; }
        public int LeaveRequestDetailId { get; set; }
        public DateTime? InDt { get; set; }
        public DateTime? OutDt { get; set; }
        public bool? IsManualEntry { get; set; }
        public bool? IsLate { get; set; }
        public string LateArrivalReason { get; set; }
        public byte? WorkDurationHours { get; set; }
        public byte? WorkDurationMinutes { get; set; }
        public byte? NoOfBreaksOfficial { get; set; }
        public byte? OfficialBreakHours { get; set; }
        public byte? OfficialBreakMinutes { get; set; }
        public byte? NoOfBreaksPersonal { get; set; }
        public byte? PersonalBreakHours { get; set; }
        public byte? PersonalBreakMinutes { get; set; }
        public bool IsOverTime { get; set; }
        public byte? OverTimeHours { get; set; }
        public string OverTimeReason { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double? WorkDurationDays { get; set; }
        public double? LeaveDurationDays { get; set; }
        public int? LeaveTypeId { get; set; }
        public double? AutoWorkDurationDays { get; set; }
        public double? AutoLeaveDurationDays { get; set; }
        public byte? LeaveDurationHours { get; set; }
        public byte? LeaveDurationMinutes { get; set; }
        public byte? OverTimeMinutes { get; set; }
        public bool AutoIsOverTime { get; set; }
        public byte? AutoOverTimeHours { get; set; }
        public byte? AutoOverTimeMinutes { get; set; }
    }
}
