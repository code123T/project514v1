﻿using Microsoft.AspNetCore.Mvc;

namespace WebShopping.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
