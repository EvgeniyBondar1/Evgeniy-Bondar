using Cinema.DataAccess.Entity;

namespace Cinema.Services.Interface
{
    public interface IRatingService
    {
        //Получить рейтинг
        Task<Rating> GetRating(int value);
        //Создать рейтинг
        Task<Rating> CreateRating(Rating rating);
        //Обновить рейтинг
        Task UpdateRating(Rating rating);
    }
}
