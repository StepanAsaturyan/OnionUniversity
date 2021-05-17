using System;
using System.Collections.Generic;

#nullable disable

namespace OnionUniversity.Infrastructure.Data
{
    public partial class Group
    {
        public int GroupId { get; set; }
        public int CourseId { get; set; }
        public string Name { get; set; }
    }
}
