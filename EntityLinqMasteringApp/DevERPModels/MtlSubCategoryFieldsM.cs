using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlSubCategoryFieldsM
    {
        public int MaterialSubCategoryFieldId { get; set; }
        public int MaterialSubCategoryFieldGroupId { get; set; }
        public int MaterialFieldId { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsMandatory { get; set; }
        public bool? IsEnterObservedValue { get; set; }
        public bool? ShowInTraveler { get; set; }
        public bool? ShowToCustomer { get; set; }
        public bool? ShowToSupplier { get; set; }
        public short FieldOrder { get; set; }
        public string FieldDisplayCell { get; set; }
        public string FieldValueCell { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool? IsJobSensitive { get; set; }
        public bool IsVariantSpecific { get; set; }
    }
}
