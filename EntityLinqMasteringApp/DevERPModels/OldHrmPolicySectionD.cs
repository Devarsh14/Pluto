using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmPolicySectionD
    {
        public int SectionId { get; set; }
        public short PolicyId { get; set; }
        public string Section { get; set; }
        public string SectionNum { get; set; }
        public string Attachment { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
