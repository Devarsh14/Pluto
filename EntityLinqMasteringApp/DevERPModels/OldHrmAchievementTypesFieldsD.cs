using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAchievementTypesFieldsD
    {
        public int FieldId { get; set; }
        public short AchievementTypeId { get; set; }
        public string FieldName { get; set; }
        public byte CellAddressX { get; set; }
        public string CellAddressY { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
