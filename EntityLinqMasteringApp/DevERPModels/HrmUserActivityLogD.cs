using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmUserActivityLogD
    {
        public long UserActivityLogId { get; set; }
        public int UserId { get; set; }
        public byte ActionTypeId { get; set; }
        public string ActionDescription { get; set; }
        public DateTime Date { get; set; }
        public bool IsDeleted { get; set; }
    }
}
