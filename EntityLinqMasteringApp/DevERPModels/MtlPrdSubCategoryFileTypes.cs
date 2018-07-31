using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdSubCategoryFileTypes
    {
        public int MaterialSubCategoryFileTypeId { get; set; }
        public int MaterialSubCategoryId { get; set; }
        public int FileTypeId { get; set; }
        public bool? AllowCustomerToUpload { get; set; }
        public bool? ShowInProduction { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
