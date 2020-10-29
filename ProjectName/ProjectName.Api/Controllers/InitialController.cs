using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProjectName.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class InitialController : Controller
    {
        /// <summary>
        /// return test value
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok("Test value");
        }
    }
}