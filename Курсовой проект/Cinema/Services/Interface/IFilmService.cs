using Cinema.DataAccess.Entity;

namespace Cinema.Services.Interface
{
    public interface IFilmService
    {
        //Получить фильм
        Task<Film> GetFilm(string name);
        //Создать фильм
        Task<Film> CreateFilm(Film film);
        //Обновить фильм
        Task UpdateFilm(Film film);
    }
}
