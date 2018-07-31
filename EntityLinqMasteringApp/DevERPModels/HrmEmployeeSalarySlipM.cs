using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeSalarySlipM
    {
        public long EmployeeSalarySlipId { get; set; }
        public long SalarySlipNo { get; set; }
        public int EmployeeId { get; set; }
        public DateTime IssueDt { get; set; }
        public short ApplicableMonth { get; set; }
        public short ApplicableYear { get; set; }
        public short TotalWorkingDays { get; set; }
        public short AttendedDays { get; set; }
        public short TotalUsedLeaves { get; set; }
        public double Othours { get; set; }
        public short EffectiveDays { get; set; }
        public double BasicPay { get; set; }
        public double TotalAddition { get; set; }
        public double TotalDeduction { get; set; }
        public double NetPayableAmount { get; set; }
        public double Ctc { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
