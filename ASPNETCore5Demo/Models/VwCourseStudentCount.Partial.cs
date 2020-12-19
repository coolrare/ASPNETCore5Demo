using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(VwCourseStudentCountMetadata))]
    public partial class VwCourseStudentCount
    {
    }

    internal class VwCourseStudentCountMetadata
    {
        // [Required]
        public Nullable<Int32> DepartmentId { get; set; }
        // [Required]
        public String Name { get; set; }
        // [Required]
        public Int32 CourseId { get; set; }
        // [Required]
        public String Title { get; set; }
        // [Required]
        public Nullable<Int32> StudentCount { get; set; }
    }
}
