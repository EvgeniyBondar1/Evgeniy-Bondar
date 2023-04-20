using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Lesson23.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; } //DbSet представляет собой коллекцию объектов, которая сопоставляется с определенной таблицей в базе данных. 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //В конструкторе с помощью вызова Database.EnsureCreated() по определению моделей будет создаваться база данных (если она отсутствует).
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //настраивается начальная конфигурация модели
        {
            modelBuilder.Entity<Book>().HasData(
                   new Book { Id = 1, Name = "Язык программирования C# 7 и платформы .NET и .NET Core", Author = "Троелсен и Джепикс", Year = 2020, Edition = "Apress" },
                   new Book { Id = 2, Name = " C# 7.0. Справочник. Полное описание языка", Author = "Джозеф Албахари", Year = 2021, Edition = "Apress" },
                   new Book { Id = 3, Name = "CLR via C#. Программирование на платформе Microsoft .NET Framework 4.5 на языке C#", Author = "Рихтер Джеффри", Year = 2022, Edition = "Питер" },
                   new Book { Id = 4, Name = "Head First. Паттерны проектирования. 2-е издание", Author = "Бейтс Берт, Сьерра Кэти", Year = 2021, Edition = "Питер" },
                   new Book { Id = 5, Name = "Чистый код", Author = "Мартин Роберт", Year = 29, Edition = "Питер" },
                   new Book { Id = 6, Name = "C# 10 и .NET 6. Современная кросс-платформенная разработка ", Author = "Прайс Марк", Year = 2023, Edition = "Питер" }
           );
        }
    }
}
