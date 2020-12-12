using System;
using System.Collections.Generic;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    public partial class Person
    {
        public Person()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
            Departments = new HashSet<Department>();
            Enrollments = new HashSet<Enrollment>();
        }

        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string Discriminator { get; set; }

        public virtual OfficeAssignment OfficeAssignment { get; set; }
        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
