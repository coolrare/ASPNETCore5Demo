using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(DepartmentMetadata))]
    public partial class Department
    {
    }

    internal class DepartmentMetadata
    {
        // [Required]
        public Int32 DepartmentId { get; set; }
        // [Required]
        public String Name { get; set; }
        // [Required]
        public Decimal Budget { get; set; }
        // [Required]
        public DateTime StartDate { get; set; }
        // [Required]
        public Nullable<Int32> InstructorId { get; set; }
        // [Required]
        public Byte[] RowVersion { get; set; }
    }
}
