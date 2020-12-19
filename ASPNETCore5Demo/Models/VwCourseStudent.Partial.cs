using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(VwCourseStudentMetadata))]
    public partial class VwCourseStudent
    {
    }

    internal class VwCourseStudentMetadata
    {
        // [Required]
        public Nullable<Int32> DepartmentId { get; set; }
        // [Required]
        public String DepartmentName { get; set; }
        // [Required]
        public Int32 CourseId { get; set; }
        // [Required]
        public String CourseTitle { get; set; }
        // [Required]
        public Nullable<Int32> StudentId { get; set; }
        // [Required]
        public String StudentName { get; set; }
    }
}
