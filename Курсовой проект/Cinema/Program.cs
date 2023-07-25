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

            //��������� ������ ����������� �� ����� ������������
            string connection = builder.Configuration.GetConnectionString("DefaultConnection");
            //��������� ��������� ������������
            builder.Services.AddControllersWithViews();
            //���������� �������� ���
            builder.Services.AddDbContext<MyDbContext>(options => options.UseSqlServer(connection));
            //��������� ��������� - IUnitOfWork � ����� - UnitOfWork
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            //����������� ��������
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
                options.Password.RequiredLength = 5;   // ����������� �����
                options.Password.RequireNonAlphanumeric = false;   // ��������� �� �� ���������-�������� �������
                options.Password.RequireLowercase = false; // ��������� �� ������� � ������ ��������
                options.Password.RequireUppercase = false; // ��������� �� ������� � ������� ��������
                options.Password.RequireDigit = false; // ��������� �� �����
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

            //��������� �������������
            app.UseRouting();
            app.UseStaticFiles();
            //app.UseHttpsRedirection();
            //��������������
            app.UseAuthentication();
            app.UseAuthorization();
            //�����������������������������
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Privacy}/{id?}");

            app.Run();

        }
    }
}