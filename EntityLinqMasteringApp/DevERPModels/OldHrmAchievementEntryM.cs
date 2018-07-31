using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmAchievementEntryM
    {
        public long AchievementId { get; set; }
        public int EmployeeId { get; set; }
        public int AchievementTypeId { get; set; }
        public byte Rating { get; set; }
        public int FinAwardAmt { get; set; }
        public string Title { get; set; }
        public DateTime AchievementDate { get; set; }
        public bool IsShowOnWebSite { get; set; }
        public DateTime? DateTillShowOnWebsite { get; set; }
        public string EntryWebDescription { get; set; }
        public string CertificateFileName { get; set; }
        public string CertificateTemplateFileName { get; set; }
        public string Barcode { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string CertificateDescription { get; set; }
    }
}
