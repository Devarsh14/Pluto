using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccLedgersLimit
    {
        public long LimitId { get; set; }
        public long LedgerId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public decimal MinLimit { get; set; }
        public decimal MaxLimit { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? OriginalLedgerId { get; set; }
    }
}
