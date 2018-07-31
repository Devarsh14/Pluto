using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmSalarySlipD
    {
        public long SalarySlipDetailId { get; set; }
        public long SalarySlipId { get; set; }
        public int SalaryComponentId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public double Amount { get; set; }
        public int? ApplicableAmountDeleteItLater { get; set; }

        public HrmSalarySlipD SalarySlipDetail { get; set; }
        public HrmSalarySlipD InverseSalarySlipDetail { get; set; }
    }
}
