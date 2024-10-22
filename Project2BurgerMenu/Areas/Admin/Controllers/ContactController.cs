using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;
using Project2BurgerMenu.Context;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult InboxContact()
        {
            var values = context.Contacts.ToList();
            return View(values);
        }

        public ActionResult DetailMessage(int id)
        {
            var value = context.Contacts.Where(x => x.ContactID == id).FirstOrDefault();
            value.IsRead = true;
            context.SaveChanges();
            return View(value);
        }

        public ActionResult MessageStatusChangeToTrue(int id)
        {
            var value = context.Contacts.Where(x => x.ContactID == id).FirstOrDefault();
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult MessageStatusChangeToFalse(int id)
        {
            var value = context.Contacts.Where(x => x.ContactID == id).FirstOrDefault();
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }

        public ActionResult DeleteMessage(int id)
        {
            var values = context.Contacts.Find(id);
            context.Contacts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}