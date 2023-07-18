using Cinema.DataAccess.DbPatterns;
using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;

namespace Cinema.Services.Service
{
    public class GenreService: ServiceConstructor, IGenreService
    {
        public GenreService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            //доделать реализацию сервисов
        }

        public async Task<Genre> GetGenre(string name)
        {
            IList<Genre> genres = await UnitOfWork.Genres.GetAll();
            return genres.First(a => a.Name == name);

        }

        public async Task<Genre> CreateGenre(Genre genre)
        {
            return await UnitOfWork.Genres.Create(genre);
        }

        public async Task UpdateGenre(Genre genre)
        {
            await UnitOfWork.Genres.Update(genre);
        }
    }
}
