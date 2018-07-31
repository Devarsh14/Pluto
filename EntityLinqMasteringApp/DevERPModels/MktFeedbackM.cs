using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.DevERPModels
{
    public partial class MktFeedbackM
    {
        public int FeedbackId { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public string Notes { get; set; }
        public byte CreatedUserId { get; set; }
        public DateTime CreatedDt { get; set; }
        public byte UpdatedUserId { get; set; }
        public DateTime UpdatedDt { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsPraise { get; set; }
        public bool IsComplaint { get; set; }
        public bool IsSuggestion { get; set; }
        public bool IsShowToCustomer { get; set; }
    }
}
