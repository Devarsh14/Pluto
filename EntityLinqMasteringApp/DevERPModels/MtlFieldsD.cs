using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlFieldsD
    {
        public long MtlPrdFieldDetId { get; set; }
        public long? MaterialSubCategoryFieldId { get; set; }
        public long MaterialId { get; set; }
        public short FieldGroupId { get; set; }
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public int FieldValueId { get; set; }
        public bool? IsEnterObservedValue { get; set; }
        public string DeviationScopeFromValue { get; set; }
        public string DeviationScopeToValue { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsVariantSpecific { get; set; }
        public bool? ShowInWebsite { get; set; }
    }
}
