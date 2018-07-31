using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmPerformanceRecordM
    {
        public int RecordId { get; set; }
        public string RecordName { get; set; }
        public string RecordType { get; set; }
        public bool? IsAffectRaise { get; set; }
        public bool? IsAffectIncentive { get; set; }
        public bool? IsAffectPromotion { get; set; }
        public short? RaiseTill { get; set; }
        public short? IncentiveTill { get; set; }
        public short? PromotionTill { get; set; }
        public string RaisePeriod { get; set; }
        public string IncentivePeriod { get; set; }
        public string PromotionPeriod { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
    }
}
