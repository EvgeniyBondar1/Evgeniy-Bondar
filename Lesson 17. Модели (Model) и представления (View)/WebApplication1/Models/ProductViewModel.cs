using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public enum Category
    {
        Sports,
        Recreation,
        Health,
        Electronics,
        Clothes
    }
    public class ProductViewModel
    {
        [Required]//
        public int Id { get; set; } = 1;
        [MaxLength(12)]//ограничение длины
        public string NameProduct { get; set; } = "";
        public Enum Category { get; set; }
        public int Count { get; set; } = 1;
        [Required]
        public double Price { get; set; } = 0;

        public ProductViewModel(int id, string nameProduct, Enum category, int count, double price)
        {
            Id = id;
            NameProduct = nameProduct;
            Category = category;
            Count = count;
            Price = price;
        }
        public ProductViewModel()
        {

        }
    }
}
