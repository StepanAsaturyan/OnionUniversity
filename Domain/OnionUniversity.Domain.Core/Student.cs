using System;
using System.Collections.Generic;

#nullable disable

namespace OnionUniversity.Infrastructure.Data
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
