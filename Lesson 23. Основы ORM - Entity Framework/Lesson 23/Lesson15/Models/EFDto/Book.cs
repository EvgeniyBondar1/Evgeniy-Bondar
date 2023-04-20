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
    //��� ������ ������������ �� �������, ������� ����� ��������� � ���� ������.
}
//����� ����������������� � ����� ������ ����� EF ��� ����� �������� ������(�����, �������������� �� ������ Microsoft.EntityFrameworkCore.DbContext).
