using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult AboutList()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }

        public ActionResult DeleteAbout(int id)
        {
            var values = context.Abouts.Find(id);
            context.Abouts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View(); 
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            context.Abouts.Add(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values=context.Abouts.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var values = context.Abouts.Find(about.AboutID);
            values.Subtitle = about.Subtitle;
            values.Title = about.Title;
            values.Description = about.Description;
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}