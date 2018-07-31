using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmLeaveRequestM
    {
        public int LeaveRequestId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime RequestDt { get; set; }
        public double LeaveDays { get; set; }
        public DateTime LeavePeriodFrom { get; set; }
        public DateTime LeavePeriodTo { get; set; }
        public int ReasonTypeId { get; set; }
        public int ReportingTo { get; set; }
        public int LeaveTypeId { get; set; }
        public string Reason { get; set; }
        public DateTime? ApprovedOn { get; set; }
        public int? ApprovedBy { get; set; }
        public int? ApproveLeaveTypeId { get; set; }
        public int? LeaveRequestReasonId { get; set; }
        public int? LeaveRejectionReasonId { get; set; }
        public string Remarks { get; set; }
        public string IsApproved { get; set; }
        public bool? IsAutoCancel { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsAdminRequired { get; set; }
        public string IsApprovedByAdmin { get; set; }
        public DateTime? ApprovedAdminOn { get; set; }
        public int? ApprovedByAdmin { get; set; }
        public bool? IsSupervisorRequired { get; set; }
        public string IsApprovedBySupervisor { get; set; }
        public DateTime? ApprovedDt { get; set; }
        public int LeaveRejectionReasonIdSupervisor { get; set; }
    }
}
