using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmIndisciplineEntryD
    {
        public int IndisciplineEntryDetailId { get; set; }
        public int IndisciplineEntryId { get; set; }
        public byte StatusId { get; set; }
        public byte? Rating { get; set; }
        public string Description { get; set; }
        public int? FinPenalty { get; set; }
        public DateTime? PromotionBarredTill { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? RaiseRestrictionTill { get; set; }
        public DateTime? ReveiwPeriodStarDt { get; set; }
        public DateTime? ReviewPeriodEndDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
