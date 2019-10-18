using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View ("Index");
        }
        
        // localhost:5000/result
        [Route("Result")]
        [HttpGet]
        public ViewResult Result()
        {
            return View ("Result");
        }

        // Processes
        // localhost:5000
        // [Route("SubmitForm")]
        // [HttpPost]
        // public IActionResult SubmitForm(string Name, string Location, string FavLanguage, string Comment)
        // {
        //     ViewBag.Name = Name;
        //     ViewBag.Location = Location;
        //     ViewBag.FavLanguage = FavLanguage;
        //     ViewBag.Comment = Comment;
        //     return View ("Result");
        // }
        [HttpPost("survey")]
        public IActionResult SubmitForm(Survey DojoMain)
        {
            if(ModelState.IsValid)
            {
                Survey NewSurvey = new Survey()
                {
                    Name = DojoMain.Name,
                    Location = DojoMain.Location,
                    FavLanguage = DojoMain.FavLanguage,
                    Comment = DojoMain.Comment,
                };
            return View ("Result", DojoMain);
            }
            else
            {
                return View ("Index");
            }
        }
    }
}
