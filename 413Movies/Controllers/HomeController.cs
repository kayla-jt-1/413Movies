using _413Movies.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private Context daContext { get; set; }
        public HomeController(ILogger<HomeController> logger, Context SomeName)
        {
            _logger = logger;
            daContext = SomeName;
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
            ViewBag.Categories = daContext.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult MovieApp(MovieResponse movieResponse)
        {
            daContext.Add(movieResponse);
            daContext.SaveChanges();
            return View("Confirmation", movieResponse);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult MovieLibrary()
        {
            var app = daContext.Responses
                .Include(x => x.Category)
                .ToList();
            return View(app);
        }

        [HttpGet]
        public IActionResult Edit(int movieId)
        {
            var movie = daContext.Responses.Single(x => x.MovieId == movieId);
            ViewBag.Categories = daContext.Categories.ToList();
            return View("MovieApp", movie);
        }

        [HttpPost]
        public IActionResult Edit(MovieResponse mr)
        {
            if (ModelState.IsValid)
            {             
                daContext.Update(mr);
                daContext.SaveChanges();
                return Redirect("MovieLibrary");
            }
            else //If invalid
            {
                ViewBag.Categories = daContext.Categories.ToList();
                return View("MovieLibrary");
            }

        }

        [HttpGet]
        public IActionResult Delete(int movieId)
        {
            var movie = daContext.Responses.Single(x => x.MovieId == movieId);
            ViewBag.Categories = daContext.Categories.ToList();
            return View("Delete", movie);
        }

        [HttpPost]
        public IActionResult Delete(MovieResponse mr)
        {
            daContext.Responses.Remove(mr);
            daContext.SaveChanges();
            return Redirect("MovieLibrary");
        }
    }
}
