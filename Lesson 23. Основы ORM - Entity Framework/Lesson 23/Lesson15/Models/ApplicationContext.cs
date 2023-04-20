using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Lesson23.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; } //DbSet ������������ ����� ��������� ��������, ������� �������������� � ������������ �������� � ���� ������. 
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
            //� ������������ � ������� ������ Database.EnsureCreated() �� ����������� ������� ����� ����������� ���� ������ (���� ��� �����������).
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //������������� ��������� ������������ ������
        {
            modelBuilder.Entity<Book>().HasData(
                   new Book { Id = 1, Name = "���� ���������������� C# 7 � ��������� .NET � .NET Core", Author = "�������� � �������", Year = 2020, Edition = "Apress" },
                   new Book { Id = 2, Name = " C# 7.0. ����������. ������ �������� �����", Author = "������ ��������", Year = 2021, Edition = "Apress" },
                   new Book { Id = 3, Name = "CLR via C#. ���������������� �� ��������� Microsoft .NET Framework 4.5 �� ����� C#", Author = "������ �������", Year = 2022, Edition = "�����" },
                   new Book { Id = 4, Name = "Head First. �������� ��������������. 2-� �������", Author = "����� ����, ������ ����", Year = 2021, Edition = "�����" },
                   new Book { Id = 5, Name = "������ ���", Author = "������ ������", Year = 29, Edition = "�����" },
                   new Book { Id = 6, Name = "C# 10 � .NET 6. ����������� �����-������������� ���������� ", Author = "����� ����", Year = 2023, Edition = "�����" }
           );
        }
    }
}
