using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmEmpSkillCategoryM
    {
        public int SkillCategoryId { get; set; }
        public string SkillCategoryName { get; set; }
        public bool IsVisible { get; set; }
        public string Description { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
