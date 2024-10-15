using Project2BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;

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

        public ActionResult DeleteCategory(int id)
        {
            var values = context.Categories.Find(id);
            context.Categories.Remove(values);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            var values=context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values=context.Categories.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateCategory(Category category)
        {
            var values = context.Categories.Find(category.CategoryID);
            values.CategoryName = category.CategoryName;
            context.SaveChanges();
            return RedirectToAction("CategoryList");
        }

       
    }
}