using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.PlutoModel
{
    public partial class Posts
    {
        public int PostId { get; set; }
        public DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
