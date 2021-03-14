using BackendProject.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading;

namespace BackendProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly SomeDataService _service;

        public ValuesController(SomeDataService service)
        {
            _service = service;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            Thread.Sleep(3000);
            return Ok(_service.GetData());
        }
    }
}
