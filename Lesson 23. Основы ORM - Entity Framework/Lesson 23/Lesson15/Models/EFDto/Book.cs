using System.ComponentModel.DataAnnotations;

namespace Lesson23.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Edition { get; set; }
    }
    //Эта модель представляет те объекты, которые будут храниться в базе данных.
}
//Чтобы взаимодействовать с базой данных через EF нам нужен контекст данных(класс, унаследованный от класса Microsoft.EntityFrameworkCore.DbContext).
