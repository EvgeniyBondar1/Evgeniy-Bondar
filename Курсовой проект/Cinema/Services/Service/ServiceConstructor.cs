using Cinema.DataAccess.DbPatterns.Interfaces;

namespace Cinema.Services.Service
{
    //Определяет взаимодействие с UnitOfWork
    public class ServiceConstructor
    {
        protected IUnitOfWork UnitOfWork;

        public ServiceConstructor(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
