using System.ComponentModel.DataAnnotations;

namespace Cinema.DataAccess.Entity
{
    public class Genre
    {
        public int GenreID{ get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        public virtual ICollection<Film> Films { get; set; }

        //Свойство public virtual ICollection<T> { get; set; } внутри сущностей Entity Framework представляет навигационное свойство, которое используется
        //для описания отношений между сущностями в базе данных.
        //Например, если у нас есть сущности "Genre" и "Film", то мы можем определить отношение
        //"один ко многим" между ними: один Genre может иметь много Film, а каждый Genre может принадлежать только к одному Film.
        //Для описания этого отношения в сущности "Genre" мы можем добавить навигационное свойство ICollection<Film>
    }
}
