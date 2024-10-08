using Project2BurgerMenu.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
       BurgerMenuContext context= new BurgerMenuContext();
        public ActionResult CategoryList()
        {
            var values =context.Categories.ToList();
            return View(values);
        }
    }
}