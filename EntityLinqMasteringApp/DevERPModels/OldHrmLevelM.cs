using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmLevelM
    {
        public short SeniorityLevelId { get; set; }
        public string SeniorityLevelName { get; set; }
        public int? LevelOrder { get; set; }
        public bool IsDeleted { get; set; }
    }
}
