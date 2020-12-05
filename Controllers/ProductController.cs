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
        List<Product> _allproduct = new List<Product>(){
            new Product{Id=1,Name="Şampuan",Price=12}
        };
        
        public ActionResult Index()
        {
            return View(_allproduct);
        }
    }
}