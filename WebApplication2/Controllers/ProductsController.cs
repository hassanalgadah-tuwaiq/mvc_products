using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product() {id = 1, name = "item 1 ", price = 99f},
            new Product() {id = 2, name = "item 2", price = 29f},
            new Product() {id = 3, name = "item 3", price = 3399f}
        };
        // GET
        public IActionResult Index()
        {
            ViewData["products"] = products;
            return View();
        }
        public IActionResult Ramdom()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            Product p;
            if (id != 0)
            {
                ViewData["found"] = false;
                foreach (var product in products)
                {
                    if (id == product.id)
                    {
                        ViewData["product"] = product;
                        ViewData["found"] = true;
                    }
                }
                return View();
            }
            ViewData["found"] = true;

            p = new Product() {id = 1, name = "item 1 ", price = 99f};
            ViewData["product"] = p;
            return View();
        }
    }
}