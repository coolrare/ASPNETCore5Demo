using System;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
            Enrollments = new HashSet<Enrollment>();
        }

        public int CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentId { get; set; }

        [JsonIgnore]
        public virtual Department Department { get; set; }
        [JsonIgnore]
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        [JsonIgnore]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
