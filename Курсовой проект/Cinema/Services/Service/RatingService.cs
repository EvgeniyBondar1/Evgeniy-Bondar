using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;

namespace Cinema.Services.Service
{
    public class RatingService : ServiceConstructor, IRatingService
    {
        public RatingService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task<Rating> GetRating(int value)
        {
            IList<Rating> ratings = await UnitOfWork.Ratings.GetAll();
            return ratings.First(a => a.Value == value);
        }

        public async Task<Rating> CreateRating(Rating rating)
        {
            return await UnitOfWork.Ratings.Create(rating);
        }

        public async Task UpdateRating(Rating rating)
        {
            await UnitOfWork.Ratings.Update(rating);
        }
    }
}
