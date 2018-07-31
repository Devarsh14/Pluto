using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.NopCommerceModel
{
    public partial class ForumsTopic
    {
        public ForumsTopic()
        {
            ForumsPost = new HashSet<ForumsPost>();
        }

        public int Id { get; set; }
        public int ForumId { get; set; }
        public int CustomerId { get; set; }
        public int TopicTypeId { get; set; }
        public string Subject { get; set; }
        public int NumPosts { get; set; }
        public int Views { get; set; }
        public int LastPostId { get; set; }
        public int LastPostCustomerId { get; set; }
        public DateTime? LastPostTime { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public Customer Customer { get; set; }
        public ForumsForum Forum { get; set; }
        public ICollection<ForumsPost> ForumsPost { get; set; }
    }
}
