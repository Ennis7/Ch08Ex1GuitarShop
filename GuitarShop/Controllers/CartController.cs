﻿using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string id)
        {
            //ViewBag.ProductSlug = id;
            TempData["message"] = "Product added.";
            return RedirectToAction("List", "Product");
        }
    }
}
