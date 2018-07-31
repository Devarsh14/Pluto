using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmContactDetailsForApplicants
    {
        public int ContactDetlId { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
