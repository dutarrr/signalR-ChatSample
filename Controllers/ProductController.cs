using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using SignalRChat.Models;


namespace SignalRChat.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View(MemoryCache.Products);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product product)
        {
            MemoryCache.Products.Add(product);
            return View();
        }
    }
}