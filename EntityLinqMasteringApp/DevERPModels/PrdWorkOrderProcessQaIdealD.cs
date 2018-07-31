using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderProcessQaIdealD
    {
        public long IdealWorkOrderProcessDetailQaid { get; set; }
        public long IdealWorkOrderProcessQaid { get; set; }
        public int FieldId { get; set; }
        public string FieldValue1 { get; set; }
        public string FieldValue2 { get; set; }
        public byte ObservedValueType { get; set; }
        public double? DeviationScopeFromValue { get; set; }
        public double? DeviationScopeToValue { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
