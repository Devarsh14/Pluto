using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmTargetTypeM
    {
        public short TargetTypeId { get; set; }
        public string TargetType { get; set; }
        public DateTime CareatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
