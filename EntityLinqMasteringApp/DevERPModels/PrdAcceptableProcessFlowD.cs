using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdAcceptableProcessFlowD
    {
        public int AcceptableProcessFlowDetId { get; set; }
        public int AcceptableProcessFlowId { get; set; }
        public int ProcessStepId { get; set; }
        public short ProcessOrder { get; set; }
        public bool IsSelected { get; set; }
        public bool IsChangeable { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
