using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(VwDepartmentCourseCountMetadata))]
    public partial class VwDepartmentCourseCount
    {
    }

    internal class VwDepartmentCourseCountMetadata
    {
        // [Required]
        public Int32 DepartmentId { get; set; }
        // [Required]
        public String Name { get; set; }
        // [Required]
        public Nullable<Int32> CourseCount { get; set; }
    }
}
