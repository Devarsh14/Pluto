using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdProcessStepOutputTypes
    {
        public int ProcessStepOutputTypeId { get; set; }
        public int ProcessStepId { get; set; }
        public int OutputTypeId { get; set; }
        public double? RejectionMargine { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
