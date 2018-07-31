using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class RightsHrm
    {
        public long HrmrightId { get; set; }
        public int EmployeeTypeId { get; set; }
        public bool GiveAccess { get; set; }
        public bool FullAccess { get; set; }
        public string DefaultPageTitle { get; set; }
        public bool EmployeeMaster { get; set; }
        public bool ViewEmployees { get; set; }
        public bool CreateEmployees { get; set; }
        public bool UpdateEmployees { get; set; }
        public bool DeleteEmployees { get; set; }
        public bool ResetPasswordOtherEmployees { get; set; }
        public bool AttendanceEntry { get; set; }
        public bool CurrentAttendanceEntry { get; set; }
        public bool OldAttendanceEntry { get; set; }
        public bool AllowExceptionsAttendance { get; set; }
        public bool LeaveApprovalsAsAdmin { get; set; }
        public bool RequestOtherEmpLeaves { get; set; }
        public bool SalaryCalculation { get; set; }
        public bool EmployeeRecords { get; set; }
        public bool ViewEmployeeRecords { get; set; }
        public bool CreateEmployeeRecords { get; set; }
        public bool UpdateEmployeeRecords { get; set; }
        public bool DeleteEmployeeRecords { get; set; }
        public bool HrmReports { get; set; }
        public bool EmpHierarchyRightsConfiguration { get; set; }
        public bool LeaveSalaryConfiguration { get; set; }
        public bool EmployeeRecordsConfiguration { get; set; }
        public bool RecruitmentConfiguration { get; set; }
        public bool HrmOtherConfiguration { get; set; }
        public bool HrmManageTraining { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool HrmPrints { get; set; }
    }
}
