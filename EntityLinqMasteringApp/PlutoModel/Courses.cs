using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.PlutoModel
{
    public partial class Courses
    {
        public Courses()
        {
            CourseSections = new HashSet<CourseSections>();
            CourseTags = new HashSet<CourseTags>();
        }

        public int CourseId { get; set; }
        public int AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public short Price { get; set; }
        public string LevelString { get; set; }
        public string Level { get; set; }

        public Authors Author { get; set; }
        public ICollection<CourseSections> CourseSections { get; set; }
        public ICollection<CourseTags> CourseTags { get; set; }
    }
}
