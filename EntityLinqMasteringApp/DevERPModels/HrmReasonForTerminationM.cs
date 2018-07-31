using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmReasonForTerminationM
    {
        public int ReasonId { get; set; }
        public string Reason { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
