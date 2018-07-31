using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeM
    {
        public short EmployeeId { get; set; }
        public short? LedgerId { get; set; }
        public short RoleId { get; set; }
        public short EmployeeTypeId { get; set; }
        public string EmployeeNum { get; set; }
        public string Fname { get; set; }
        public string Mname { get; set; }
        public string Lname { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinCode { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string EmailId { get; set; }
        public string PhoneNum { get; set; }
        public string MobileNum { get; set; }
        public string PhotoIdtype { get; set; }
        public string PhotoIdnum { get; set; }
        public string OfficialmailId { get; set; }
        public DateTime JoinDate { get; set; }
        public int JoinSalary { get; set; }
        public bool JoinSalaryType { get; set; }
        public int CurrentSalary { get; set; }
        public bool CurrentSalaryType { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string PresAddress1 { get; set; }
        public string PresAddress2 { get; set; }
        public string PresCity { get; set; }
        public string PresState { get; set; }
        public string PresCountry { get; set; }
        public string PresPinCode { get; set; }
        public string PresPhoneNum { get; set; }
        public string BloodGroup { get; set; }
        public bool IsFullAccessEmployee { get; set; }
        public string SeniorityLevel { get; set; }
        public DateTime? DesignationSinceDt { get; set; }
        public int ReportingToId { get; set; }
        public int DepartmentId { get; set; }
        public string Employment { get; set; }
        public short Status { get; set; }
        public DateTime? LastDateofEmployment { get; set; }
        public int? ReasonForTermination { get; set; }
        public bool? HasProcessByPassInClose { get; set; }
        public DateTime? ContractCompletionDt { get; set; }
        public bool? IsRenewable { get; set; }
        public bool? IsPromotable { get; set; }
        public bool? IsTerminationPenality { get; set; }
        public short? PenaltyType { get; set; }
        public long? SigningupAmount { get; set; }
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
        public int? SalaryBase { get; set; }
        public bool? AllowAccessDuringAbsence { get; set; }
        public bool IsApplicableEpf { get; set; }
        public int? CityId { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public DateTime? ValidIddt { get; set; }
        public int PresCityId { get; set; }
        public int PresStateId { get; set; }
        public int PresCountryId { get; set; }
        public string BankAccountNo { get; set; }
        public string BankAccountName { get; set; }
        public string PhoneExtNo { get; set; }
    }
}
