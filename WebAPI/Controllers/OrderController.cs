using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using WebAPI.DTO;
using WebAPI.Models;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/order/{system}")]
    public class OrderController : ControllerBase
    {
        private readonly IRepository _repository;
        public OrderController(IRepository repository)
        {
            _repository = repository;
        }

        // POST: OrderController/Create
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]Order order, string system)
        {
            OrderItem orderItem = new OrderItem()
            {
                OrderNumber = order.OrderNumber,
                SourceOrder = JObject.FromObject(order).ToString(),
                SystemType = system,
                CreatedAt = DateTime.Now
            };

            await _repository.SaveOrderItem(orderItem);

            return Ok();
        }






    }
}
