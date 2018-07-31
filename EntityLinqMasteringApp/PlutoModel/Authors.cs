using System;
using System.Collections.Generic;

namespace EntityLinqMasteringApp.PlutoModel
{
    public partial class Authors
    {
        public Authors()
        {
            Courses = new HashSet<Courses>();
        }

        public int AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection<Courses> Courses { get; set; }
    }
}
