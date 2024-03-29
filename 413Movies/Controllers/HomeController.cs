﻿using _413Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace _413Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Context BlahContext { get; set; }
        public HomeController(ILogger<HomeController> logger, Context SomeName)
        {
            _logger = logger;
            BlahContext = SomeName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieApp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieApp(MovieResponse movieResponse)
        {
            BlahContext.Add(movieResponse);
            BlahContext.SaveChanges();
            return View("Confirmation", movieResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
