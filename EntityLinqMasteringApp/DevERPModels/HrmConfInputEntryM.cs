using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmConfInputEntryM
    {
        public long ConfId { get; set; }
        public int ReportToId { get; set; }
        public string InputAbout { get; set; }
        public int TopicId { get; set; }
        public string Details { get; set; }
        public int ReporterId { get; set; }
        public byte Status { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
