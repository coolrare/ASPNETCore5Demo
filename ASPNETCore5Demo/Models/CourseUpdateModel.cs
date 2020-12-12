
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore5Demo.Models
{
    [ModelMetadataType(typeof(CourseUpdateModelMetadata))]
    public class CourseUpdateModel
    {
        public string Title { get; set; }

        public int Credits { get; set; }
    }

    internal class CourseUpdateModelMetadata
    {
        [Required]
        [StringLength(30, ErrorMessage = "Title 太長")]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }
    }
}