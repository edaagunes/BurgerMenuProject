using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;

namespace Project2BurgerMenu.Controllers
{
    public class DefaultController : Controller
    {
       BurgerMenuContext context=new BurgerMenuContext();

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

        public PartialViewResult PartialAbout()
        { 
            var values=context.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTodaysOffer()
        {
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }

        public PartialViewResult PartialGallery()
        {
            return PartialView();
        }

        public PartialViewResult PartialContact()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
    }
}