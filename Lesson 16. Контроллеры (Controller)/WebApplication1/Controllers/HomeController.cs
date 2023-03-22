using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            //Console.WriteLine("Hello world!");
            //var httpContex1 = ControllerContext.HttpContext;
            //var httpContex = HttpContext.Request;
            //return Content("Hello!");
            //return Redirect("~Profile/Privacy");
            //ViewData[]
            //ViewData["Number1"] = 1;
            //ViewData["Number2"] = 2;
            //ViewData["Number3"] = 3;
            //ViewData["Number4"] = 4;
            //ViewBag.Message = "Hello message!";
             var numberArray= new int[] { 1, 2, 3}; 
             return View(numberArray);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public string Login(string username, string password) 
        {
            const string userNameInBase = "Artem";
            const string passwordUser = "123";

            if (username == userNameInBase && password == passwordUser)
            {
                 Redirect("~/Home/Index");
            }

            return "Not found";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}