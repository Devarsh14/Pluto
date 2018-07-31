using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktFeedbackFactorM
    {
        public byte FeedbackFactorId { get; set; }
        public string FeedbackFactorName { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public byte? CategoryId { get; set; }
        public decimal? FeedbackWeightage { get; set; }
        public int? FeedbackAlert { get; set; }
    }
}
