using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.EntityFrameworkCore;

namespace DotNetCoreWeb.Controllers
{
    public class GoodsController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new EfDbContext())
            {
                var goods = db.Goods.ToList();
                return View(goods);
            }
        }

        public string hello()
        {
            return "hello";
        }
    }
}