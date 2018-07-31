using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.PlutoModel
{
    public partial class Tags
    {
        public Tags()
        {
            CourseTags = new HashSet<CourseTags>();
        }

        public int TagId { get; set; }
        public string Name { get; set; }

        public ICollection<CourseTags> CourseTags { get; set; }
    }
}
