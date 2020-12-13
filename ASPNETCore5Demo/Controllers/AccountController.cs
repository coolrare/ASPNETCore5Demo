using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPNETCore5Demo.Models;
using Microsoft.Extensions.Logging;
using ASPNETCore5Demo.Helpers;
using Microsoft.AspNetCore.Http;

namespace ASPNETCore5Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly ILogger<AccountController> logger;
        private readonly JwtHelpers jwt;
        public AccountController(ILogger<AccountController> logger, JwtHelpers jwt)
        {
            this.jwt = jwt;
            this.logger = logger;
        }

        [HttpPost("~/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesDefaultResponseType]
        public ActionResult<LoginResult> Login(LoginModel model)
        {
            if (ValidateUser(model))
            {
                return new LoginResult()
                {
                    Token = jwt.GenerateToken(model.Username, 10)
                };
            }
            else
            {
                return BadRequest();
            }
        }

        private bool ValidateUser(LoginModel model)
        {
            return true;
        }
    }
}