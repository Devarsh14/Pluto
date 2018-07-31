using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class HrmQualificationM
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public string ShortName { get; set; }
        public string Specialization { get; set; }
    }
}
