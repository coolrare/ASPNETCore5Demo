using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore5Demo.Models;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;

namespace ASPNETCore5Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IOptions<JwtSettings> jwtSettings;
        private readonly ILogger<ConfigController> logger;

        public ConfigController(IOptions<JwtSettings> jwtSettings, ILogger<ConfigController> logger)
        {
            this.jwtSettings = jwtSettings;
            this.logger = logger;
        }

        [HttpGet("")]
        public ActionResult<JwtSettings> GetJwtSettingss()
        {
            logger.LogTrace("Trace");
            logger.LogDebug("Debug");
            logger.LogInformation("Information");
            logger.LogWarning("Warning: Issuer {Issuer}", jwtSettings.Value.Issuer);
            logger.LogError("Error");
            logger.LogCritical("Critical");

            return jwtSettings.Value;
        }
    }
}