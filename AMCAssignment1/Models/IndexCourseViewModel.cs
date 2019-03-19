using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMCAssignment1.Models
{
    public class IndexCourseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfEnrollments { get; set; }

    }
}