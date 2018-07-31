using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmLeaveTypeM
    {
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public string LeaveCategory { get; set; }
        public string Description { get; set; }
        public byte AdditionFormula { get; set; }
        public int? CalenderDaysForAdditionFormula { get; set; }
        public int? WorkingDaysForAdditionFormula { get; set; }
        public byte? LeaveAdditionPeriod { get; set; }
        public int? MonthsForLeaveAdditionPeriod { get; set; }
        public DateTime? FixedDateForLeaveAdditionPeriod { get; set; }
        public byte? IsLeaveAdditionAuto { get; set; }
        public byte Eligibility { get; set; }
        public int? CalenderDaysForEligibility { get; set; }
        public int? WorkingDaysForEligibility { get; set; }
        public byte LeaveExpiry { get; set; }
        public int? MonthsForLeaveExpiry { get; set; }
        public DateTime? FixedDateForLeaveExpiry { get; set; }
        public int MaxLeaveBalance { get; set; }
        public short LeaveNoticePeriod { get; set; }
        public double MinimumLeaves { get; set; }
        public bool IsEncashmentPossible { get; set; }
        public int? MinimumLeavesForEncashment { get; set; }
        public int? MaximumLeavesForEncashment { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int LeaveAddedCellX { get; set; }
        public string LeaveAddedCellY { get; set; }
        public int LeaveAvailableCellX { get; set; }
        public string LeaveAvailableCellY { get; set; }
        public int LeaveUsedCellX { get; set; }
        public string LeaveUsedCellY { get; set; }
        public bool AllowNegativeBalance { get; set; }
        public byte? Payability { get; set; }
        public string LeaveShortName { get; set; }
        public int? MinimumBackDays { get; set; }
        public short? MaximumLeaves { get; set; }
    }
}
