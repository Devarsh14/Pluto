using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlSubCategoryStatusOption
    {
        public short StatusOptionId { get; set; }
        public string StatusName { get; set; }
        public int? SubCategoryId { get; set; }
        public short? StatusOrder { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
