using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //Allows us to add in seeded data
        private MovieInfoContext daContext { get; set; }


        //Constructor
        public HomeController(MovieInfoContext someName)
        {
            daContext = someName;
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
            ViewBag.Categories = daContext.Categories.ToList();

            return View(new ApplicationResponse());
        }


        //Post for Movie Application form Page.
        [HttpPost]
        public IActionResult MovieApplication(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                daContext.Add(ar);
                daContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else
            {
                ViewBag.Categories = daContext.Categories.ToList();

                return View();
            }

        }


        //Get For Movie List - Displays all movies in database.
        [HttpGet]
        public IActionResult MovieList ()
        {
            var applications = daContext.Responses
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(applications);
        }


        //Edit Get and Post

        [HttpGet]
        public IActionResult Edit(int applicationid)
        {
            ViewBag.Categories = daContext.Categories.ToList();

            var movie = daContext.Responses.Single(x => x.MovieID == applicationid);

            return View("MovieApplication", movie);
        }

        [HttpPost]
        public IActionResult Edit (ApplicationResponse ar)
        {
            daContext.Update(ar);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }



        //Delete Get and Post
        
        [HttpGet]
        public IActionResult Delete(int applicationid)
        {
            var movie = daContext.Responses.Single(x => x.MovieID == applicationid);

            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            daContext.Responses.Remove(ar);
            daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
