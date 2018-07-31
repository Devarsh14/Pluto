using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class WipbalanceM
    {
        public int WipbalanceId { get; set; }
        public int ProcessGroupId { get; set; }
        public double Wip { get; set; }
        public double Production { get; set; }
        public DateTime RptAsOnDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
