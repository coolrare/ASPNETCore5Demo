using System;
using System.Collections.Generic;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    public partial class VwDepartmentCourseCount
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int? CourseCount { get; set; }
    }
}
