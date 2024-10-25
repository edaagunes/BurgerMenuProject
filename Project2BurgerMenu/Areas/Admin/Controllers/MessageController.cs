using Project2BurgerMenu.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Entities;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        // GET: Admin/Message

        BurgerMenuContext context = new BurgerMenuContext();

        public ActionResult Inbox()
        {
            var userName = Session["x"];
            var email=context.Admins.Where(x=>x.Username == userName).Select(y=>y.Email).FirstOrDefault();
            var values=context.Messages.Where(x=>x.ReceiverEmail==email).ToList();
            return View(values);
        }

        public ActionResult SendBox()
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.SenderEmail == email).ToList();
            return View(values);
        }

        public PartialViewResult PartialDetailMessage(int id)
        {
            var message = context.Messages.Find(id);
           
            return PartialView(message);
        }

        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message message)
        {
            var userName = Session["x"];
            var email = context.Admins.Where(x => x.Username == userName).Select(y => y.Email).FirstOrDefault();
            message.SenderEmail = email;
            message.IsRead = false;
            message.SendDate = DateTime.Now;
            context.Messages.Add(message);
            context.SaveChanges();
            return RedirectToAction("SendBox","Message", new {area="Admin"});
        }
    }
}

