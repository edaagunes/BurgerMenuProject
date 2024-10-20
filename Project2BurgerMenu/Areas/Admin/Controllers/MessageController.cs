using Project2BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class MessageController : Controller
    {
        // GET: Admin/Message

        BurgerMenuContext context = new BurgerMenuContext();

        public ActionResult Inbox()
        {
            var values = context.Messages.ToList();
            return View(values);
        }

        public ActionResult DetailMessage(int id)
        {
            var value = context.Messages.Where(x => x.MessageID == id).FirstOrDefault();
            value.IsRead = true;
            context.SaveChanges();
            return View(value);
        }

        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var value = context.Messages.Where(x => x.MessageID == id).FirstOrDefault();
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult MessageStatusChangeToFalse(int id)
        {
            var value = context.Messages.Where(x => x.MessageID == id).FirstOrDefault();
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = context.Messages.Find(id);
            context.Messages.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}

