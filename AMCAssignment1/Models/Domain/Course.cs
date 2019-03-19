using System.Collections.Generic;

namespace AMCAssignment1.Models.Domain
{
    public class Course
    {
        public Course()
        {
            Users = new List<ApplicationUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
        public int NumberOfEnrollments { get; set; }
        public string UserId { get; set; }
        public virtual List<ApplicationUser> Users { get; set; }
    }
}