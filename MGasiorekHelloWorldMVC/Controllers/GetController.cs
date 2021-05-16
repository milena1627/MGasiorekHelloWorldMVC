﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MGasiorekHelloWorldMVC.Controllers
{
    public class GetController : Controller
    {
        public IActionResult Index(String name)
        {
            ViewData["name"] = name;
            return View();
        }
    }
}
