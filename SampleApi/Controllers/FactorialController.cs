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
    public class FactorialController : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<int>> Get(int id)
        {
            int result = 1;
            for (int i = 1; i <= id; i++)
                result *= i;
            return new int[] { result };
        }
        [HttpPost("{number}")]
        public int Post(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
                result *= i;
            return result ;
        }
    }
}