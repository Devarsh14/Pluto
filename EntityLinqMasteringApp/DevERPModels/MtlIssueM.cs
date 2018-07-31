using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlIssueM
    {
        public int MaterialIssueId { get; set; }
        public int MaterialIssueRequestId { get; set; }
        public int Status { get; set; }
        public string MaterialIssueSlipConfigNo { get; set; }
        public string Notes { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSynched { get; set; }
    }
}
