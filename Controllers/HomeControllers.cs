using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Dojo_survey
{
    public class HomeController : Controller
    {

        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }


        [HttpGet("results")]
        public ViewResult Results()
        {
            return View();
        }


        [HttpPost("method")]
        public ViewResult FormSubmit(string Name, string Location, string Language, string Comment)
        {
            ViewBag.name = Name;
            ViewBag.location = Location;
            ViewBag.language = Language;
            ViewBag.comment = Comment;

            return View("results");
        }
    }
}