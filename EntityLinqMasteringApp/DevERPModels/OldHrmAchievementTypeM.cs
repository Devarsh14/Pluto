using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAchievementTypeM
    {
        public short AchievementTypeId { get; set; }
        public string AchievementType { get; set; }
        public byte Rating { get; set; }
        public string CertificateFileName { get; set; }
        public bool IsCertificate { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public int FinAwardMinAmt { get; set; }
        public int FinAwardMaxAmt { get; set; }
        public bool IsShowOnWebsite { get; set; }
        public short DaysToShowOnWebsite { get; set; }
        public DateTime? CreatedDt { get; set; }
        public short CreatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public short? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
