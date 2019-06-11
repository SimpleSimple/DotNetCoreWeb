using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    //[ApiController]
    public class OrderController : ControllerBase
    {
        public Order Get()
        {
            return new Order { Id = 201906111608, CreateId = 1000, CreateTime = DateTime.Now };
        }

        public Order GetOrder([FromQuery]long orderId, string orderName = "床头柜")
        {
            var order = new Order
            {
                Id = orderId,
                OrderName = orderName,
                CreateId = 1000,
                CreateTime = DateTime.Now
            };
            return order;
        }
    }
}