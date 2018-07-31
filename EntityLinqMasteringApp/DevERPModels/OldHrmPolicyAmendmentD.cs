using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmPolicyAmendmentD
    {
        public int AmendmentId { get; set; }
        public short PolicySectionId { get; set; }
        public string Amendment { get; set; }
        public string AmendmentNum { get; set; }
        public DateTime AmendmentDt { get; set; }
        public string Attachment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int? PolicyCategoryId { get; set; }
        public int? PolicyId { get; set; }
        public DateTime EffectiveFromDt { get; set; }
        public bool? IsLocked { get; set; }
    }
}
