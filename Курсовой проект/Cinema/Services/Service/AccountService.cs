using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;

namespace Cinema.Services.Service
{
    //Создаем конкретный сервис, который будет общаться через UnitOfWork c конкретным репозиторием
    public class AccountService: ServiceConstructor, IAccountService
    {
        public AccountService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public async Task<Account> GetAccount(string email) 
        {
            IList<Account> accounts = await UnitOfWork.Accounts.GetAll();
            return accounts.First(a => a.Email == email);
        }

        public async Task<Account> CreateAccount(Account account) 
        { 
            return await UnitOfWork.Accounts.Create(account);
        }

        public async Task UpdateAccount(Account account) 
        { 
            await UnitOfWork.Accounts.Update(account);
        }
    }
}
