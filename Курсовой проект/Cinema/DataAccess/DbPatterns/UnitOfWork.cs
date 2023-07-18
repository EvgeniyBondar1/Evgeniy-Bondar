using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;

namespace Cinema.DataAccess.DbPatterns
{
    
    public class UnitOfWork: IUnitOfWork
    {
        private readonly MyDbContext _context;
        public UnitOfWork(MyDbContext context)
        {
            _context = context;
        }
        //Позволяет общаться с базой данных (конкретной таблицей) через репозиторий
        public IGenericRepository<Account> Accounts => new GenericRepository<Account>(_context);
        public IGenericRepository<Comment> Comments => new GenericRepository<Comment>(_context);
        public IGenericRepository<Film> Films => new GenericRepository<Film>(_context);
        public IGenericRepository<Genre> Genres => new GenericRepository<Genre>(_context);  
        public IGenericRepository<Rating> Ratings => new GenericRepository<Rating>(_context);   
        public IGenericRepository<Role> Roles => new GenericRepository<Role>(_context);
    }
}
