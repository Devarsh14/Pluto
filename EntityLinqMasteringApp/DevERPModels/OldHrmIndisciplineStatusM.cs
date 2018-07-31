using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmIndisciplineStatusM
    {
        public byte IndisciplineStatusId { get; set; }
        public string StatusName { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
