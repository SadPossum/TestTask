using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

namespace BackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string[] lines =
{
            "Lorem ipsum dolor sit amet.",
            "Lorem ipsum dolor sit amet consectetur adipisicing elit. Pariatur, similique?",
            "Lorem ipsum dolor sit amet consectetur."
            };

            Thread.Sleep(3000);

            return lines;
        }
    }
}
