using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdResponsibleMaterialD
    {
        public int ResponsibleMaterialId { get; set; }
        public int OutputTypeId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
