using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class OldHrmIndisciplineEntryM
    {
        public long IndisciplineEntryId { get; set; }
        public short IndisciplineTypeId { get; set; }
        public byte StatusId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime IndisciplineDate { get; set; }
        public string Indiscipline { get; set; }
        public byte Rating { get; set; }
        public int FinPenaltyAmt { get; set; }
        public DateTime? FinPenaltyDueDt { get; set; }
        public DateTime? ResoponseDueDt { get; set; }
        public DateTime? PromotionBarredTillDt { get; set; }
        public DateTime? RaiseRestrictionTillDt { get; set; }
        public bool? IsTerminate { get; set; }
        public string Description { get; set; }
        public string NoticeFileName { get; set; }
        public string NoticeTemplateName { get; set; }
        public string Barcode { get; set; }
        public string Smssyntax { get; set; }
        public DateTime? EmployeeRespondedDt { get; set; }
        public string EmployeeResponse { get; set; }
        public DateTime? FinalDecisionDt { get; set; }
        public string DecisionDescription { get; set; }
        public bool IsReviewRequired { get; set; }
        public byte ReviewStatusId { get; set; }
        public int? ReviewFinPenaltyAmt { get; set; }
        public DateTime? ReviewFinPenaltyDueDt { get; set; }
        public DateTime? ReviewPromotionBarredTillDt { get; set; }
        public DateTime? ReviewRaiseRestrictionTillDt { get; set; }
        public bool? IsTerminateEmployeInReview { get; set; }
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
    }
}
