using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdFreeProcessSteps
    {
        public short FreeProcessStepId { get; set; }
        public int ProcessStepId { get; set; }
        public DateTime FirstAvailableDt { get; set; }
        public bool IsAccessed { get; set; }
        public short ProcessOrder { get; set; }
    }
}
