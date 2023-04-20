using Lesson23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Diagnostics;

namespace Lesson23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ApplicationContext db;
        public HomeController(ILogger<HomeController> logger, ApplicationContext context)
        {
            _logger = logger;
            db = context;
        }      

        public IActionResult Index()
        {
            return View();
        }
        // Создание
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //Изменение
        public IActionResult Edit(int? id)
        {
            if (id != null)
            {
                var book = db.Books.FirstOrDefault(p => p.Id == id);
                if (book != null)
                    return View(book);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
            return RedirectToAction("Privacy");
        }
        // Удаление
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                var book = db.Books.FirstOrDefault(p => p.Id == id);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                    return RedirectToAction("Privacy");
                }
            }
            return NotFound();
        }

        public IActionResult Privacy()
        {
            var books = db.Books.ToList();
            return View(books);
        }
    }   
}
//Entity Framework - ORM-решение, которое позволяет автоматически связать обычные классы языка C# с таблицами в базе данных.
//Entity Framework Core понадобится для  работы с СУБД MS SQL Server
//для работы Entity Framework необходим пакет Microsoft.EntityFrameworkCore.SqlServer.