using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmReviewM
    {
        public int ReviewId { get; set; }
        public DateTime StartDt { get; set; }
        public DateTime EndDt { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public DateTime? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
