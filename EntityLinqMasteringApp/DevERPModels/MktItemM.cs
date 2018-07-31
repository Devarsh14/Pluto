using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktItemM
    {
        public long ItemId { get; set; }
        public long SubHeadingId { get; set; }
        public long MaterialId { get; set; }
        public string ItemName { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int SetId { get; set; }
        public long PartCrmid { get; set; }
    }
}
