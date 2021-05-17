using System;
using System.Collections.Generic;

#nullable disable

namespace OnionUniversity.Infrastructure.Data
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
