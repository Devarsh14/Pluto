using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.PlutoModel
{
    public partial class CourseTags
    {
        public int CourseId { get; set; }
        public int TagId { get; set; }

        public Courses Course { get; set; }
        public Tags Tag { get; set; }
    }
}
