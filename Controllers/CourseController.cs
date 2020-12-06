using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore5Demo.Models;

namespace ASPNETCore5Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ContosoUniversityContext db;
        public CourseController(ContosoUniversityContext db)
        {
            this.db = db;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            return db.Courses.ToList();
        }

        // [HttpGet("{id}")]
        // public ActionResult<Course> GetCourseById(int id)
        // {
        //     return null;
        // }

        // [HttpPost("")]
        // public ActionResult<Course> PostCourse(Course model)
        // {
        //     return null;
        // }

        // [HttpPut("{id}")]
        // public IActionResult PutCourse(int id, Course model)
        // {
        //     return NoContent();
        // }

        // [HttpDelete("{id}")]
        // public ActionResult<Course> DeleteCourseById(int id)
        // {
        //     return null;
        // }
    }
}