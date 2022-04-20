using System;
using System.Collections.Generic;

#nullable disable

namespace School_5.Models
{
    public partial class OfficeAssignment
    {
        public int InstructorID { get; set; }
        public string Location { get; set; }
        public byte[] Timestamp { get; set; }

        public virtual Person Instructor { get; set; }
    }
}
