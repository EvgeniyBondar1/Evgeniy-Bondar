using Cinema.DataAccess;
using Cinema.DataAccess.DbPatterns;
using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;
using Cinema.Services.Service;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
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
            builder.Services.AddIdentity<Account, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 5;   // минимальная длина
                options.Password.RequireNonAlphanumeric = false;   // требуются ли не алфавитно-цифровые символы
                options.Password.RequireLowercase = false; // требуются ли символы в нижнем регистре
                options.Password.RequireUppercase = false; // требуются ли символы в верхнем регистре
                options.Password.RequireDigit = false; // требуются ли цифры
            }).AddEntityFrameworkStores<Providers.Database.EFProvider.DataContext>()
    .AddDefaultTokenProviders();
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