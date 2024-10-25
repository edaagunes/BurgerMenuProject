using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project2BurgerMenu.Context;
using Project2BurgerMenu.Entities;
using PagedList;
using PagedList.Mvc;

namespace Project2BurgerMenu.Areas.Admin.Controllers
{
    public class ReservationController : Controller
    {
        BurgerMenuContext context=new BurgerMenuContext();
        public ActionResult ReservationList(int page = 1)
        {
            var values=context.Reservations.ToList().ToPagedList(page, 5);
            return View(values);
        }

        [HttpGet]
        public ActionResult DetailReservation(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
            return View(value);
        }

        [HttpPost]
        public ActionResult DetailReservation(Reservation reservation)
        {
            var values = context.Reservations.Find(reservation.ReservationID);
            values.Name = reservation.Name;
            values.Surname = reservation.Surname;
            values.Email = reservation.Email;
            values.Phone = reservation.Phone;
            values.PeopleCount = reservation.PeopleCount;
            values.ReservationDate = reservation.ReservationDate;
            values.Time = reservation.Time;
            values.Message = reservation.Message;
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }


        public ActionResult StatusChangeToConfirm(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
            value.ReservationStatus = "Onaylandı";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToCancel(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
            value.ReservationStatus = "İptal Edildi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToWait(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
            value.ReservationStatus = "Onay Bekleniyor";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }

        public ActionResult StatusChangeToCame(int id)
        {
            var value = context.Reservations.Where(x => x.ReservationID == id).FirstOrDefault();
            value.ReservationStatus = "Müşteri Gelmedi";
            context.SaveChanges();
            return RedirectToAction("ReservationList");
        }
    }
}