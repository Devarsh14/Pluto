using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldServiceM
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public int? GroupId { get; set; }
        public int? LedgerId { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
