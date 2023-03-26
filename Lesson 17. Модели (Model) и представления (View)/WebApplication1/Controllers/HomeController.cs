using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProductViewModel[] productViewModels;

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

        public IActionResult Product()
        {
            productViewModels = new ProductViewModel[]
            {
                new ProductViewModel(1, "Кettlebell",  Category.Sports, 4, 235.50),
                new ProductViewModel(2, "Dumbbells",  Category.Sports, -100, 223.50),
                new ProductViewModel(3, "Horizontal bar", Category.Sports, 4, 122.50),
                new ProductViewModel(4, "TV", Category.Electronics, 4, 356.50),
                new ProductViewModel(5, "Iron", Category.Electronics, 54, 445.50),
                new ProductViewModel(6, "Teapot", Category.Electronics, 23, 665.50),
                new ProductViewModel(7, "Socks",  Category.Clothes, 45, 677.50),
                new ProductViewModel(8, "Jacket",  Category.Clothes, -32, 66.50),
                new ProductViewModel(9, "Vitamins",  Category.Health, 22, 455.50),
                new ProductViewModel(10, "Backpack", Category.Recreation, 35, 456.50),
                new ProductViewModel(11, "Glasses", Category.Recreation, -55, 44.50),
            };
            return View(productViewModels);
        }

        [HttpGet]
        public IActionResult Login()
        {
            //return Redirect("~/Home/Product");
            return View();
        }

        [HttpPost]
        public void Login(LoginViewModel loginViewModel) 
        {
            const string userLogin = "Admin";
            const string userPassword = "Admin";


            if (Equals(userLogin, loginViewModel.UserName) && Equals(userPassword, loginViewModel.Password))
            {
                Redirect("~/Home/Product");
                Product();
            }
            else
            {
                Console.WriteLine("Not found");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}