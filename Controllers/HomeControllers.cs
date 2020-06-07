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


        [HttpPost("method")]
        public ViewResult FormSubmit(Person FromForm)
        {
            if(ModelState.IsValid)
            {
                return View("results", FromForm);
            }
            return View("Index");
        }
    }
}