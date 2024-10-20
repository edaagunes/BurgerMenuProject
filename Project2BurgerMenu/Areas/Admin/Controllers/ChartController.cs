using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;
using Microsoft.Ajax.Utilities;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();

        public ActionResult ProductStockChart()
        {
            return View();
        }
        public ActionResult CategoryProductChart()
        {
            // Kategori ve ürün sayısı ilişkisini alıyoruz
            var data = context.Categories
                .Where(c => c.Products.Count > 0)
                .Select(c => new
                {
                    CategoryName = c.CategoryName,
                    ProductCount = c.Products.Count
                })
                .ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }
        
    }
}