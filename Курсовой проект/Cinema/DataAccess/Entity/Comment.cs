using System.ComponentModel.DataAnnotations;

namespace Cinema.DataAccess.Entity
{
    public class Comment
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }//Описание

        public Film Film { get; set; }
        public Guid FilmId { get; set; }//Установка внешнего ключа

        public Account Account { get; set; }
        public Guid AccountId { get; set; }//Установка внешнего ключа
    }
}
