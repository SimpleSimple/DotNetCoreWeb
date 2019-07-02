using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class OrderController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}