﻿using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmSalaryExpenseHead
    {
        public int SalaryExpHeadId { get; set; }
        public int EmployeeId { get; set; }
        public int LedgerId { get; set; }
        public double Role { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public string IsDeleted { get; set; }
    }
}
