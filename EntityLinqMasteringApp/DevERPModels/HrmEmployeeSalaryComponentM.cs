using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeSalaryComponentM
    {
        public int EmployeeSalaryComponentId { get; set; }
        public int SalaryComponentId { get; set; }
        public double Amount { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsApplicable { get; set; }
        public int EmployeeId { get; set; }
    }
}
