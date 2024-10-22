using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Entities
{
    public class Subscribe
    {
        public int SubscribeID { get; set; }

        [Required(ErrorMessage = "Email Giriniz")]
        [EmailAddress(ErrorMessage = "Geçersiz Email Formatı")]
        public string SubscribeEmail { get; set; }
    }
}