
using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNETCore5Demo.Models
{
    public class CourseUpdateModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Title 太長")]
        public string Title { get; set; }

        [Required]
        public int Credits { get; set; }
    }
}