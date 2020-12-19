using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(DepartmentDropDownMetadata))]
    public partial class DepartmentDropDown
    {
    }

    internal class DepartmentDropDownMetadata
    {
        // [Required]
        public Int32 DepartmentId { get; set; }
        // [Required]
        public String Name { get; set; }
    }
}
