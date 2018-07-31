using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmSalaryComponentM
    {
        public int SalaryComponentId { get; set; }
        public string SalaryComponentName { get; set; }
        public string Applicability { get; set; }
        public int AdditionDeductionLevel { get; set; }
        public int DisplayPosition { get; set; }
        public bool IsStatutary { get; set; }
        public int LedgerId { get; set; }
        public double? ApplicableValue { get; set; }
        public byte IsDeduction { get; set; }
        public short? CellAddressX { get; set; }
        public string CellAddressY { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? ApplicableLevel { get; set; }
    }
}
