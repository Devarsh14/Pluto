using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class AccProjectD
    {
        public int ProjectDetailId { get; set; }
        public int ProjectId { get; set; }
        public int LedgerId { get; set; }
        public string RoleBasisType { get; set; }
        public double RolePercent { get; set; }
        public bool? IsLedgerId { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public int? OriginalLedgerId { get; set; }
    }
}
