using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(CourseInstructorMetadata))]
    public partial class CourseInstructor
    {
    }

    internal class CourseInstructorMetadata
    {
        // [Required]
        public Int32 CourseId { get; set; }
        // [Required]
        public Int32 InstructorId { get; set; }
    }
}
