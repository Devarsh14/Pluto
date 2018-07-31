using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmployeeSkillM
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillCategoryId { get; set; }
        public decimal? FinancialValue { get; set; }
        public bool? IsFamilierities { get; set; }
        public short MinNoOfEmpShouldKnow { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
