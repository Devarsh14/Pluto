using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldPrdStatusM
    {
        public int StatusId { get; set; }
        public short StatusNum { get; set; }
        public string Status { get; set; }
        public string StatusHead { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }
    }
}
