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
    [Authorize]
    public class ProductController : Controller
    {
        BurgerMenuContext context = new BurgerMenuContext();
        public ActionResult ProductList(int page = 1)
        {
            var values = context.Products.ToList().ToPagedList(page,4);
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("ProductList");

        }

        public ActionResult DeleteProduct(int id)
        {
            var value = context.Products.Find(id);
            context.Products.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        [HttpGet]
        public ActionResult UpdateProduct(int id) 
        {
            List<SelectListItem> values = (from x in context.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;

            var value=context.Products.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateProduct(Product product)
        {
            var value=context.Products.Find(product.ProductID);
            value.ProductName = product.ProductName;
            value.ImageUrl = product.ImageUrl;
            value.Description = product.Description;
            value.Price = product.Price;
            value.CategoryID = product.CategoryID;
            context.SaveChanges();
            return RedirectToAction("ProductList");
        }

        // Secilen Kategoriye Ait Ürünleri Listeler
        public ActionResult CategoryProducts(int id)
        {
            var values = context.Products.Where(x => x.CategoryID == id).ToList();
            return View(values);
        }
    }
}