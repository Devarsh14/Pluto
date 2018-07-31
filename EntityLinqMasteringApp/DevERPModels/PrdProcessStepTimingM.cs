using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessStepTimingM
    {
        public int ProcessStepTimingId { get; set; }
        public int ProcessStepId { get; set; }
        public byte WeekdayId { get; set; }
        public short? TypeId { get; set; }
        public DateTime? StartTime1 { get; set; }
        public DateTime? EndTime1 { get; set; }
        public DateTime? StartTime2 { get; set; }
        public DateTime? EndTime2 { get; set; }
        public DateTime? StartTime3 { get; set; }
        public DateTime? EndTime3 { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsZero { get; set; }
        public bool? Is24Hours { get; set; }
        public bool? IsOther { get; set; }
    }
}
