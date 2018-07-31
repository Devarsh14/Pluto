using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.PlutoModel
{
    public partial class CourseSections
    {
        public int SectionId { get; set; }
        public int CourseId { get; set; }
        public string Title { get; set; }

        public Courses Course { get; set; }
    }
}
