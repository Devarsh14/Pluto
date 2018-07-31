using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class PrdWorkOrderMultiValueFieldD
    {
        public long WorkOrderMultiValueFieldDetId { get; set; }
        public long WorkOrderId { get; set; }
        public int ProductId { get; set; }
        public short? VersionNum { get; set; }
        public short FieldGroupId { get; set; }
        public int SrNoRow { get; set; }
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public short FieldValueId { get; set; }
        public string ObservedFieldValue1 { get; set; }
        public short? ObservedFieldValueId1 { get; set; }
        public string ObservedFieldValue2 { get; set; }
        public short? ObservedFieldValueId2 { get; set; }
        public string ObservedFieldValue3 { get; set; }
        public short? ObservedFieldValueId3 { get; set; }
        public DateTime CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
