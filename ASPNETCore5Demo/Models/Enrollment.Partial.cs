using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
    }

    internal class EnrollmentMetadata
    {
        // [Required]
        public Int32 EnrollmentId { get; set; }
        // [Required]
        public Int32 CourseId { get; set; }
        // [Required]
        public Int32 StudentId { get; set; }
        // [Required]
        public Nullable<Int32> Grade { get; set; }
    }
}
