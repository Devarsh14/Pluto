using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmPolicyM
    {
        public short PolicyId { get; set; }
        public short PolicyCategoryId { get; set; }
        public string PolicyName { get; set; }
        public string PolicyNum { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsLocked { get; set; }
    }
}
