using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("[controller]")]
    public class HelloworldController : ControllerBase
    {
        private readonly ILogger<HelloworldController> _logger;

        public HelloworldController(ILogger<HelloworldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Helloworld";
        }
    }
}
