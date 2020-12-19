using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(PersonMetadata))]
    public partial class Person
    {
    }

    internal class PersonMetadata
    {
        // [Required]
        public Int32 Id { get; set; }
        // [Required]
        public String LastName { get; set; }
        // [Required]
        public String FirstName { get; set; }
        // [Required]
        public Nullable<DateTime> HireDate { get; set; }
        // [Required]
        public Nullable<DateTime> EnrollmentDate { get; set; }
        // [Required]
        public String Discriminator { get; set; }
    }
}
