using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;
using TodoList.Server;
using Microsoft.AspNetCore.Cors;

namespace TodoList.Controllers
{
    //允许跨域
    [EnableCors]
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private readonly ILogger<ItemsController> _logger;

        public ItemsController(ILogger<ItemsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String Get()
        {
            string response = GetItemsListServer.GetItem();
            return response;
        }
    }

}
