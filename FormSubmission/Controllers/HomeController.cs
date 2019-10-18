using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("survey")]
        public IActionResult SubmitForm(User UserSurvey)
        {
            User NewUser = new User()
            {
                FirstName = UserSurvey.FirstName,
                LastName = UserSurvey.LastName,
                Age = UserSurvey.Age,
                Email = UserSurvey.Email,
                Password = UserSurvey.Password,
            };
            return View ("Success", NewUser);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
