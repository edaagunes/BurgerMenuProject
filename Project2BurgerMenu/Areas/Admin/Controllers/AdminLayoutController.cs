using Project2BurgerMenu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class AdminLayoutController : Controller
    {
        BurgerMenuContext context=new BurgerMenuContext();
        // GET: Admin/AdminLayout
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult PartialCategoryAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialCategoryAdd(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return PartialView();
        }
    }
}