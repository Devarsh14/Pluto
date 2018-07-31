using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktNewsM
    {
        public long NewsId { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public string ImageName { get; set; }
        public string LinkUrl { get; set; }
        public DateTime DisplayFromDt { get; set; }
        public DateTime? DisplayToDt { get; set; }
        public DateTime? NewsDt { get; set; }
        public bool ShowNewsDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
