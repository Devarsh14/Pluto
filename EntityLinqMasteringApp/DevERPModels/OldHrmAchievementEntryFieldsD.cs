using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAchievementEntryFieldsD
    {
        public long FieldDetlId { get; set; }
        public int AchievementId { get; set; }
        public int FieldId { get; set; }
        public string FieldValue { get; set; }
        public int CellAddressX { get; set; }
        public string CellAddressY { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
