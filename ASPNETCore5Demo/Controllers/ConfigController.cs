using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore5Demo.Models;
using Microsoft.Extensions.Options;

namespace ASPNETCore5Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IOptions<JwtSettings> jwtSettings;

        public ConfigController(IOptions<JwtSettings> jwtSettings)
        {
            this.jwtSettings = jwtSettings;
        }

        [HttpGet("")]
        public ActionResult<JwtSettings> GetJwtSettingss()
        {
            return jwtSettings.Value;
        }
    }
}