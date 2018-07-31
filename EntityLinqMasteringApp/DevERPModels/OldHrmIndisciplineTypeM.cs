using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmIndisciplineTypeM
    {
        public short IndisciplineTypeId { get; set; }
        public string IndisciplineType { get; set; }
        public bool IsNotice { get; set; }
        public byte Rating { get; set; }
        public string TemplateFileName { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public byte ResponseDays { get; set; }
        public int FinPenaltyMinAmt { get; set; }
        public int FinPenaltyMaxAmt { get; set; }
        public byte FinPenaltyDueDays { get; set; }
        public byte PromotionBarredMonths { get; set; }
        public byte RaiseRestrictionMonths { get; set; }
        public bool IsTerminateEmployee { get; set; }
        public bool IsReviewRequired { get; set; }
        public byte ReviewDays { get; set; }
        public int? ReviewFinPenaltyMinAmt { get; set; }
        public int? ReviewFinPenaltyMaxAmt { get; set; }
        public byte ReviewFinPenaltyDueDays { get; set; }
        public byte ReviewPromotionBarredMonths { get; set; }
        public byte ReviewRaiseRestrictionMonths { get; set; }
        public bool? IsTerminateEmployeeInReview { get; set; }
        public string Smssyntax { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedUserId { get; set; }
        public DateTime? UpdatedDt { get; set; }
        public int? UpdatedUserId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
