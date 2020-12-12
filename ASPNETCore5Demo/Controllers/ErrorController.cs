﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCore5Demo.Controllers
{
    public class ErrorController : ControllerBase
    {
        [HttpGet("/error")]
        public IActionResult Index()
        {
            return Problem();
        }
    }
}