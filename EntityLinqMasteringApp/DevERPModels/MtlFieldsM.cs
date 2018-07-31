using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MtlFieldsM
    {
        public int MaterialFieldId { get; set; }
        public int MaterialFieldGroupId { get; set; }
        public string MaterialField { get; set; }
        public string FieldDisplayName { get; set; }
        public short MaterialFieldTypeId { get; set; }
        public short MaterialFieldOrder { get; set; }
        public string FieldDescription { get; set; }
        public bool IsUsedInAutoQuote { get; set; }
        public bool HasFixValueOld { get; set; }
        public bool ShowInInfoSheet { get; set; }
        public bool ShowInQuotation { get; set; }
        public bool ShowInTraveler { get; set; }
        public bool? ShowInMaster { get; set; }
        public bool? AllowChangeOfType { get; set; }
        public bool IsEnterObservedValue { get; set; }
        public byte? ObservedValueType { get; set; }
        public bool IsDeletePossible { get; set; }
        public bool IsMandatory { get; set; }
        public short? FieldDisplayCellX { get; set; }
        public string FieldDisplayCellY { get; set; }
        public short? FieldValueCellX { get; set; }
        public string FieldValueCellY { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public int Criticality { get; set; }
        public bool IsPublishedSpecification { get; set; }
        public bool IsRequireUnit { get; set; }
        public short? DefaultUnitId { get; set; }
        public bool? ShowInWebsite { get; set; }
        public bool NeedforProduction { get; set; }
        public bool NeedforOrder { get; set; }
        public string FieldShortName { get; set; }
    }
}
