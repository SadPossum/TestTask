using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
