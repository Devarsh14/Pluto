using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlPrdMultiValueFieldD
    {
        public long MaterialMultiValueFieldDetId { get; set; }
        public long? MaterialSubCategoryFieldId { get; set; }
        public long MaterialId { get; set; }
        public int MaterialFieldGroupId { get; set; }
        public int SrNoRow { get; set; }
        public int MaterialFieldId { get; set; }
        public string Value { get; set; }
        public int MaterialFieldValueId { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
