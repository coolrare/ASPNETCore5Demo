using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course
    {
    }

    internal class CourseMetadata
    {
        [Required]
        public Int32 CourseId { get; set; }
        // [Required]
        public String Title { get; set; }
        // [Required]
        public Int32 Credits { get; set; }
        // [Required]
        public Int32 DepartmentId { get; set; }
    }
}
