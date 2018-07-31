using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmDesignationM
    {
        public short EmployeeTypeId { get; set; }
        public string EmployeeTypeName { get; set; }
        public string DesignationToDisplay { get; set; }
        public int DesignationRank { get; set; }
        public string DefaultModulePage { get; set; }
        public string Description { get; set; }
        public bool AuthorityToRecmaterial { get; set; }
        public short ReportingToEmployeeTypeId { get; set; }
        public int MaximumSalary { get; set; }
        public int MinimumSalary { get; set; }
        public int IncrementedSalary { get; set; }
        public short NoOfPeopleRequired { get; set; }
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
        public bool RequireLeaveApprovalFromSupervisor { get; set; }
        public bool RequireLeaveApprovalFromAdmin { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsConsiderDirectLabour { get; set; }
        public string FileTitle { get; set; }
        public string FileType { get; set; }
        public string SalaryRange { get; set; }
        public bool? IsAllowJobApplication { get; set; }
        public string StandardInstruction { get; set; }
    }
}
