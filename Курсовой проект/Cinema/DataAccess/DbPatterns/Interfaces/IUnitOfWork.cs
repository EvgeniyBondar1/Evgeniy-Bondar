using Cinema.DataAccess.Entity;

namespace Cinema.DataAccess.DbPatterns.Interfaces
{
    // Репозитории (количество таблиц, хранящихся в БД)
    public interface IUnitOfWork
    {
        IGenericRepository<Account> Accounts { get; }
        IGenericRepository<Comment> Comments { get; }
        IGenericRepository<Film> Films { get; } 
        IGenericRepository<Genre> Genres { get; }
        IGenericRepository<Rating> Ratings { get; }
        IGenericRepository<Role> Roles { get; }
    }
}
