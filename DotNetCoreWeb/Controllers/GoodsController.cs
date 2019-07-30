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
        private readonly EfDbContext _db;

        public GoodsController(EfDbContext context)
        {
            this._db = context;
        }

        public IActionResult Index()
        {
            //using (var db = new EfDbContext())
            //{
            var list = new List<GoodsOutput>();
            var goods = _db.Goods.ToList();
            if (goods == null)
            {
                throw new Exception("Goods为空");
            }
            if (goods != null && goods.Count > 0)
            {
                foreach (var item in goods)
                {
                    var dto = new GoodsOutput();
                    dto.Id = item.Id;
                    dto.Name = item.Name;
                    //ht.Add("修改", "javascript:void(0)");
                    ht.Add($"javascript:do_miaosha({item.Id})", "秒杀");

                    foreach (var key in ht.Keys)
                    {
                        dto.Operate = $"<a v-on:click=\"{key}\" href=\"javascript:;\">{ht[key]}</a>";
                    }
                    list.Add(dto);
                }
            }
            ViewBag.ReturnModel = System.Web.HttpUtility.HtmlDecode(Ace.JsonHelper.Serialize(list));
            return View();
        }

        public string hello()
        {
            return "hello";
        }

        public async Task<string> test()
        {
            for (int i = 1; i <= 100000; i++) {
                // calc code
            }
            return "hello";
        }
    }
}