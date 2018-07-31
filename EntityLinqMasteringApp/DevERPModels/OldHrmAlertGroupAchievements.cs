using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAlertGroupAchievements
    {
        public short AlertGroupAchievementId { get; set; }
        public short AlertGroupId { get; set; }
        public short AchievementTypeId { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
