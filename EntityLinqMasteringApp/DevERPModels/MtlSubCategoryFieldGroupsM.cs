using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlSubCategoryFieldGroupsM
    {
        public int MaterialSubCategoryFieldGroupId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int MaterialFieldGroupId { get; set; }
        public short MaterialFieldGroupOrder { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
