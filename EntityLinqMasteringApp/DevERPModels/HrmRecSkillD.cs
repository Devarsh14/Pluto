using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmRecSkillD
    {
        public short SkillDetId { get; set; }
        public short EmployeeTypeId { get; set; }
        public int SkillId { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsNecessary { get; set; }
    }
}
