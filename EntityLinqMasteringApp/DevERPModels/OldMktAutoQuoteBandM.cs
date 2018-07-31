using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldMktAutoQuoteBandM
    {
        public int AutoQuoteBandId { get; set; }
        public string BandName { get; set; }
        public int LowerLimit { get; set; }
        public int UpperLimit { get; set; }
        public byte Unit { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
