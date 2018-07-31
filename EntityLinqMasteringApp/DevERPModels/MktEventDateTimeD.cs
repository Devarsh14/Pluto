using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktEventDateTimeD
    {
        public int EventDtid { get; set; }
        public int EventId { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public DateTime CreatedUserId { get; set; }
        public DateTime UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
