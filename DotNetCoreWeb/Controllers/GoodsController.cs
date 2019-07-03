using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWeb.DTO;
using Microsoft.AspNetCore.Mvc;
using MyProject.EntityFrameworkCore;

namespace DotNetCoreWeb.Controllers
{
    public class GoodsController : Controller
    {
        private Hashtable ht = new Hashtable();

        public IActionResult Index()
        {
            using (var db = new EfDbContext())
            {
                var output = new List<GoodsOutput>();
                var goods = db.Goods.ToList();
                foreach (var item in goods)
                {
                    var dto = new GoodsOutput();
                    dto.Id = item.Id;
                    dto.Name = item.Name;
                    //ht.Add("修改", "javascript:void(0)");
                    ht.Add($"javascript:do_miaosha({item.Id})", "秒杀");

                    foreach (var key in ht.Keys)
                    {
                        dto.Operate = $"<a href=\"{key}\">{ht[key]}</a>";
                    }
                    output.Add(dto);
                }
                return View(output);
            }
        }

        public string hello()
        {
            return "hello";
        }
    }
}