using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdAcceptableProcessFlowM
    {
        public int AcceptableProcessFlowId { get; set; }
        public long SubCategoryId { get; set; }
        public string AcceptableProcessFlowName { get; set; }
        public string AcceptableProcessFlowCode { get; set; }
        public bool IsDefault { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
