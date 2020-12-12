using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPNETCore5Demo.Models;
using Omu.ValueInjecter;
using Microsoft.AspNetCore.Http;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi;
using NSwag.Annotations;

namespace ASPNETCore5Demo.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ContosoUniversityContext db;
        public CourseController(ContosoUniversityContext db)
        {
            this.db = db;
        }

        [HttpGet("error")]
        public IActionResult Error()
        {
            throw new Exception("ERROR");
            return Ok("TEST");
        }

        [HttpGet("empty")]
        public IActionResult Empty()
        {
            return Ok("TEST");
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Course>> GetCourses()
        {
            return db.Courses.ToList();
        }

        [HttpGet("credits/{credit}")]
        public ActionResult<IEnumerable<Course>> GetCoursesByCredit(int credit)
        {
            return db.Courses.Where(p => p.Credits == credit).ToList();
        }

        [HttpGet("{id}")]
        [OpenApiOperation("GetCourseById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public ActionResult<Course> GetCourseById(int id)
        {
            var c = db.Courses.Find(id);

            if (c == null)
            {
                return NotFound();
            }

            return c;
        }

        [HttpPost("")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesDefaultResponseType]
        public ActionResult<Course> PostCourse(Course model)
        {
            db.Courses.Add(model);
            db.SaveChanges();

            return Created("/api/Course/" + model.CourseId, model);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesDefaultResponseType]
        public IActionResult PutCourse(int id, CourseUpdateModel model)
        {
            var c = db.Courses.Find(id);
            // c.Credits = model.Credits;
            // c.Title = model.Title;

            // using Omu.ValueInjecter;
            c.InjectFrom(model);

            db.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult<Course> DeleteCourseById(int id)
        {
            var c = db.Courses.Find(id);
            db.Courses.Remove(c);
            db.SaveChanges();

            // db.Database.ExecuteSqlRaw($"DELETE FROM db.Course WHERE CourseId={id}");

            return Ok(c);
        }

        [HttpDelete("all")]
        public ActionResult<Course> DeleteCourseAll()
        {
            db.Database.ExecuteSqlRaw($"DELETE FROM db.Course");

            return null;
        }

    }
}