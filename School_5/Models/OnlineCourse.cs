using System;
using System.Collections.Generic;

#nullable disable

namespace School_5.Models
{
    public partial class OnlineCourse
    {
        public int CourseID { get; set; }
        public string URL { get; set; }

        public virtual Course Course { get; set; }
    }
}
