using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(OfficeAssignmentMetadata))]
    public partial class OfficeAssignment
    {
    }

    internal class OfficeAssignmentMetadata
    {
        // [Required]
        public Int32 InstructorId { get; set; }
        // [Required]
        public String Location { get; set; }
    }
}
