using Cinema.DataAccess.Entity;

namespace Cinema.Services.Interface
{
    public interface IGenreService
    {
        //Получить жанр
        Task<Genre> GetGenre(string name);
        //Создать жанр
        Task<Genre> CreateGenre(Genre genre);
        //Обновить жанр
        Task UpdateGenre(Genre genre);
    }
}
