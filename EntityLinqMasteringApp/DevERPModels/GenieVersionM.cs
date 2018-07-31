using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class GenieVersionM
    {
        public int GenieVersionId { get; set; }
        public int VersionNum { get; set; }
        public DateTime CreatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
