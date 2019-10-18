using Microsoft.AspNetCore.Mvc;
namespace ASPNetProject.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost:5000
        [Route("")]
        [HttpGet]
        public string HelloFromController()
        {
            return "Hello from Controller";
        }

        // localhost:5000/hello
        [Route("hello")]
        [HttpGet]
        public string Hello()
        {
            return "Hi Again!";
        }
    }
}