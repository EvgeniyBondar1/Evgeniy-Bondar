using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Feedback()
        {
            return View();
        }
    }
}
