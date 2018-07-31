using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAlertGroupM
    {
        public byte AlertGroupId { get; set; }
        public string AlertGroupName { get; set; }
        public string AlertGroupDisplayName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
