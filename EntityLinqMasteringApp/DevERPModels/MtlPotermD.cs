using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPotermD
    {
        public long PotermDetId { get; set; }
        public long Poid { get; set; }
        public short PotermId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
