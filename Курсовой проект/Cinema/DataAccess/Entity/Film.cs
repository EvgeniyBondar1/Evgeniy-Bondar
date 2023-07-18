using System.ComponentModel.DataAnnotations;

namespace Cinema.DataAccess.Entity
{
    public class Film
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }//Описание
        public string YoutubeId { get; set; }
        
        [Required]
        public Genre Genre { get; set; }//Жанр

        public int GenreId { get; set; }      
        public DateTime? Year { get; set; }
        public string Director { get; set; }
        public string ImageXPath { get; set; }

        /// <param name="id">ID</param>
        /// <param name="name">Название</param>
        /// <param name="description">Описание</param>
        /// <param name="youtube">Ссылка на превью</param>
        /// <param name="genre">Жанр</param>
        /// <param name="year">Год выхода</param>
        /// <param name="director">Режиссер</param>
        /// <param name="imageXPath">Постер</param>

        public virtual ICollection<Comment> Comments { get; set; }//Установка связи один ко многим
        public virtual ICollection<Rating> Ratings { get; set; }//Установка связи один ко многим

    }
}
