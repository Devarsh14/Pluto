using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktFeedbackCategoryM
    {
        public byte CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string AlertEmail { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short? CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
