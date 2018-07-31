using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class NewsComment
    {
        public int Id { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public int NewsItemId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public Customer Customer { get; set; }
        public News NewsItem { get; set; }
    }
}
