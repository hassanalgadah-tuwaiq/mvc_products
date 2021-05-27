using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        List<Product> products = new List<Product>()
        {
            new Product()
            {
                id = 1, name = "Clarity & Connection", price = 99f,
                img = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/5248/9781524860486.jpg"
            },
            new Product()
            {
                id = 2, name = "Inward", price = 29f,
                img = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4494/9781449495756.jpg"
            },
            new Product()
            {
                id = 3, name = "Pillow Thoughts", price = 3399f,
                img = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9781/4494/9781449489755.jpg"
            }
        };

        // GET
        public IActionResult Index(int id,string color)
        {
            ViewData["products"] = products;
            ViewData["color"] = color;
            return View();
        }

        public IActionResult Ramdom()
        {
            return View();
        }
        public IActionResult Namecolor(string name)
        {
            ViewData["name"] = name;
            Console.WriteLine(name);
            return View();
        }

        public IActionResult Details(int id)
        {
            ViewData["found"] = false;
            Product p = products.Find(pro => pro.id == id);
            if (p != null)
            {
                ViewData["product"] = p;
                ViewData["found"] = true;
            }
            return View();
        }
    }
}