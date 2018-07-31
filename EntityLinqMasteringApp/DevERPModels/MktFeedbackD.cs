using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktFeedbackD
    {
        public int FeedbackDetId { get; set; }
        public int FeedbackId { get; set; }
        public int FeedbackFactorId { get; set; }
        public double FeedbackFactorValue { get; set; }
        public byte CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public byte UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
