using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlSetM
    {
        public int SetId { get; set; }
        public string SetName { get; set; }
        public string SetCode { get; set; }
        public int FamilyId { get; set; }
        public bool IsVariantSet { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
