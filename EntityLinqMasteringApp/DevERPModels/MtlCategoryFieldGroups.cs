using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlCategoryFieldGroups
    {
        public int MaterialTypeFieldGroupId { get; set; }
        public int MaterialCategoryId { get; set; }
        public int MaterialFieldGroupId { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
