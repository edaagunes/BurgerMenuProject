using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}