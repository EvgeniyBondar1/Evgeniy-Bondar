using Cinema.DataAccess;
using Cinema.DataAccess.DbPatterns;
using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;
using Cinema.Services.Service;
using Microsoft.EntityFrameworkCore;

namespace Cinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //Получение строки подключения из файла конфигурации
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");
            //Добавляем поддержку контроллеров
            builder.Services.AddControllersWithViews();
            //Определяем контекст тут
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            //Связываем интерфейс - IUnitOfWork и класс - UnitOfWork
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            //Регистрация сервисов
            builder.Services.AddTransient<IAccountService, AccountService>();
            builder.Services.AddTransient<ICommentService, CommentService>();
            builder.Services.AddTransient<IFilmService, FilmService>();
            builder.Services.AddTransient<IGenreService, GenreService>();
            builder.Services.AddTransient<IRatingService, RatingService>();
            builder.Services.AddTransient<IRoleService, RoleService>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            //Поддержка маршрутизации
            app.UseRouting();
            app.UseStaticFiles();
            //app.UseHttpsRedirection();
            //Аутентификация
            app.UseAuthentication();
            app.UseAuthorization();
            //Устанавливаемсопоставлениемар
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Privacy}/{id?}");

            app.Run();
        }
    }
}