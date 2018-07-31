using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmDesignationSkillD
    {
        public int EmpDesigDetId { get; set; }
        public int EmployeeTypeId { get; set; }
        public int SkillId { get; set; }
        public int PreferenceId { get; set; }
        public int? LevelId { get; set; }
        public decimal? Persantage { get; set; }
        public decimal PersantageUtilised { get; set; }
        public int SkillWorth { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
