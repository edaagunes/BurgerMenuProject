using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project2BurgerMenu.Entities
{
    public class Product
    {
        public int ProductID { get; set; }

        [StringLength(100)]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public bool? DealofTheDay { get; set; }
    }
}