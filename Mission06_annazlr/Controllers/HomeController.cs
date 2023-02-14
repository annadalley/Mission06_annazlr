using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_annazlr.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_annazlr.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        //Allows us to add in seeded data
        private MovieInfoContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieInfoContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        //Controller for Index Page.
        public IActionResult Index()
        {
            return View();
        }

        //Controller for My Podcast page
        public IActionResult MyPodcasts()
        {
            return View();
        }

        //Get for Movie Application Form Page
        [HttpGet]
        public IActionResult MovieApplication()
        {
            return View();
        }

        //Post for Movie Application form Page.
        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse ar)
        {
            blahContext.Add(ar);
            blahContext.SaveChanges();

            return View("Confirmation", ar);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
