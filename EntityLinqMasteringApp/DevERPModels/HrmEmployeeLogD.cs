using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeLogD
    {
        public int EmployeeLogDetId { get; set; }
        public int EmployeeId { get; set; }
        public short EmployeeTypeId { get; set; }
        public DateTime? IdealInTime { get; set; }
        public DateTime? WorkHoursFullDay { get; set; }
        public DateTime? WorkHoursHalfDay { get; set; }
        public DateTime? WorkHoursOverTime { get; set; }
        public bool? IsLatePolicyApplicable { get; set; }
        public DateTime? MinTimeLateArrival { get; set; }
        public DateTime? AllowedMaxHoursLateArrival { get; set; }
        public bool? IsConsiderAsHalfDayForLate { get; set; }
        public bool? IsApplicablePayDeductPolicyOnLateArrival { get; set; }
        public byte? MaxAllowedLateArrivalsPerMonth { get; set; }
        public string MaxDayIncomeDeductOnLateArrival { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
