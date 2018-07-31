using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class BlogComment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CommentText { get; set; }
        public int BlogPostId { get; set; }
        public DateTime CreatedOnUtc { get; set; }

        public BlogPost BlogPost { get; set; }
        public Customer Customer { get; set; }
    }
}
