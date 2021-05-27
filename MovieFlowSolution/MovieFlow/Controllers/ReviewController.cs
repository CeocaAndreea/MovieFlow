using Bogus;
using Microsoft.AspNetCore.Mvc;
using MovieFlow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieFlow.Controllers
{
    public class ReviewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReviewList()
        {
            ViewBag.Title = "Review Section";
            ViewBag.Description = "Here you have a review section for the movie or TvSerie you are interested in." +
            "You can also add a new review if you want by writing your name and the review in the two textbox " +
            "that are fond below.";
            List<ReviewCatalog> moviesReview = new List<ReviewCatalog>();
            for (int i = 0; i < 30; i++)
            { /*I am creating fake users reviews using Bogus */
                moviesReview.Add(new Faker<ReviewCatalog>()
                .RuleFor(p => p.ReviewName, f => f.Name.FirstName() + " " + f.Name.LastName())
                .RuleFor(p => p.ReviewDescription, f => f.Rant.Review())
                );
            }
            return View(moviesReview);
        }

    }
}
