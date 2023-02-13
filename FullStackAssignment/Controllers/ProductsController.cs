using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullStackAssignment.Models;

namespace FullStackAssignment.Controllers
{
    public class ProductsController : Controller
    {
        ProductDB db = new ProductDB();
        [HttpGet]
        public ActionResult GetProducts()
        {
            List<Product> products = db.Products.ToList();
            return View(products);
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product newProduct)
        {
            db.Products.Add(newProduct);
            db.SaveChanges();
            return View();
        }
    }
}