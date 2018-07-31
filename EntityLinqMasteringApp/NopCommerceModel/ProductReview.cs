using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ProductReview
    {
        public ProductReview()
        {
            ProductReviewHelpfulness = new HashSet<ProductReviewHelpfulness>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public bool IsApproved { get; set; }
        public string Title { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
        public int HelpfulYesTotal { get; set; }
        public int HelpfulNoTotal { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
        public ICollection<ProductReviewHelpfulness> ProductReviewHelpfulness { get; set; }
    }
}
