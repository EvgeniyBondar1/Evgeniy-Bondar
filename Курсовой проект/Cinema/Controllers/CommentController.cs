using Microsoft.AspNetCore.Mvc;
using Cinema.DataAccess.Entity;
using Cinema.Models;
using Cinema.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Controllers
{
    public class CommentController : Controller
    {
        private ICommentService commentService;
        private IFilmService filmService;
        public CommentController(ICommentService commentService, IFilmService filmService)
        {
            this.commentService = commentService;
            this.filmService = filmService;
        }


        [AllowAnonymous]
        public IActionResult Feedback()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Feedback(Comment model, string Id)
        {
            Comment comment = new Comment()
            {
                Id = Guid.NewGuid(),
                Description = model.Description,
                FilmId = Guid.Parse(Id),
                AccountId = Guid.Parse("BC8AB5C8-D9C8-4D7F-9A23-EFEEE110D4ED"),
            };
            await commentService.CreateComment(comment);

            return RedirectToAction("FeedbackDetails", "Comment");
        }
        [HttpGet]
        public async Task<IActionResult> FeedbackDetails()
        {
            return View();
        }

        //[HttpPost]
        //[AllowAnonymous]
        //public IActionResult FeedbackDetails()
        //{
        //    return View();


        //}
    }
}
