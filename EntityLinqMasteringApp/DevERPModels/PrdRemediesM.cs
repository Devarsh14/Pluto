using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdRemediesM
    {
        public int RemediesId { get; set; }
        public string RemediesName { get; set; }
        public bool? IsRemedyForRejection { get; set; }
        public bool IsRemedyForLowProduction { get; set; }
        public byte RemedyTypeId { get; set; }
        public bool? IsCommon { get; set; }
        public bool IsRejection { get; set; }
        public int OutputTypeId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsRemedyForRework { get; set; }
    }
}
