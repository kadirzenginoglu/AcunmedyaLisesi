﻿using Microsoft.AspNetCore.Mvc;

namespace AcunmedyaLisesi.Web.Controllers
{
    public class FenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}