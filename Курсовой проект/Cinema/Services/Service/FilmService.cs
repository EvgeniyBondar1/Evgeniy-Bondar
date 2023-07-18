using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;

namespace Cinema.Services.Service
{
    public class FilmService: ServiceConstructor, IFilmService
    {
        public FilmService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }

        public async Task<Film> GetFilm(string name)
        {
            IList<Film> films = await UnitOfWork.Films.GetAll();
            return films.First(a => a.Name == name);

        }

        public async Task<Film> CreateFilm(Film film)
        {
            return await UnitOfWork.Films.Create(film);
        }

        public async Task UpdateFilm(Film film)
        {
            await UnitOfWork.Films.Update(film);
        }
    }
}
