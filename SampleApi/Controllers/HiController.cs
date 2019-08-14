using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string >> Get()
        {
            return new string[] { "Hello" };
        }
    }
}