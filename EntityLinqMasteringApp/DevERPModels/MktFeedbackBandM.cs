using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktFeedbackBandM
    {
        public int FeedbackBandId { get; set; }
        public double BandValue { get; set; }
        public string BandType { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}
