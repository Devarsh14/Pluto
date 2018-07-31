using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktWebsitePagesM
    {
        public int LinkId { get; set; }
        public string LinkName { get; set; }
        public string LinkDisplayText { get; set; }
        public string PageName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDt { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public int UpdatedUserId { get; set; }
        public int ParentLinkId { get; set; }
        public int LinkLevelId { get; set; }
        public int DisplayOrder { get; set; }
        public bool? Visible { get; set; }
    }
}
