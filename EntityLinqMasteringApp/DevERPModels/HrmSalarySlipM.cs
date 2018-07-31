using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmSalarySlipM
    {
        public long SalarySlipId { get; set; }
        public long SalarySlipNo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime SalaryFromDt { get; set; }
        public DateTime SalaryToDt { get; set; }
        public double TotalWorkingDays { get; set; }
        public double TotalAttendedDays { get; set; }
        public double TotalPaidHolidays { get; set; }
        public double TotalLeaveDays { get; set; }
        public double TotalAbsentDays { get; set; }
        public string Othours { get; set; }
        public double? Otdays { get; set; }
        public double? Otamount { get; set; }
        public double NetSalary { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string ApplicableMonth { get; set; }
        public int? ApplicableYear { get; set; }
        public double Ctc { get; set; }
        public long? VoucherId { get; set; }
        public bool IsSynched { get; set; }
    }
}
