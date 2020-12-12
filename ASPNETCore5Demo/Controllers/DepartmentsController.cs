using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore5Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;

namespace ASPNETCore5Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ContosoUniversityContext db;
        public DepartmentsController(ContosoUniversityContext db)
        {
            this.db = db;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<Department>> GetDepartments()
        {
            return db.Departments.AsNoTracking().ToList();
        }

        [HttpGet("ddl")]
        public ActionResult<IEnumerable<DepartmentDropDown>> GetDepartmentDropDown()
        {
            // return db.Database.SqlQuery<DepartmentDropDown>($"SELECT DepartmentID, Name FROM dbo.Department").ToList();

            // return db.Departments.Select(p => new DepartmentDropDown() {
            //     DepartmentId = p.DepartmentId,
            //     Name = p.Name
            // }).ToList();

            return db.DepartmentDropDown.FromSqlInterpolated($"SELECT DepartmentID, Name FROM dbo.Department").ToList();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public ActionResult<IEnumerable<Course>> GetDepartmentCourses(int id)
        {
            var dept = db.Departments.Include(p => p.Courses)
                         .FirstOrDefault(p => p.DepartmentId == id);

            if (dept == null)
            {
                return NotFound();
            }

            return dept.Courses.ToList();

            // return db.Courses.Where(p => p.DepartmentId == id).ToList();
        }
    }
}