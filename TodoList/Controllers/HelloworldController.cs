using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using TodoList.Model;

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
        public Items Get()
        {
            var item = new Items();
            item.Id = "1";
            item.Task = "HelloWorld!";
            item.Data = "2021/7/25 2:31";
            return item;
        }
    }
}
