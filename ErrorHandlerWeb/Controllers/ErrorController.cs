using ErrorHandlerWeb.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;


namespace ErrorHandlerWeb.Controllers
{
    [ApiController]
    [Route("api/error/")]
    public class ErrorController : ControllerBase
    {
        private readonly ILogger<ErrorController> _logger;
        public ErrorController(ILogger<ErrorController> logger)
        {
            _logger = logger;
        }
        // POST: OrderController/Create
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]ErrorMessage order)
        {
            _logger.LogError(order.ToString());
            Thread.Sleep(1000 * 30);
            return Ok();
        }
    }
}
