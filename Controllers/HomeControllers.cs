using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Dojo_survey.Models;

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
        public ViewResult FormSubmit(Person FromForm)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Person = FromForm;
                return View("results");
            }
            else
            {
                return View("Index");
            }
        }
    }
}