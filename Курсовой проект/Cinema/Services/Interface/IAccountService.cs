using Cinema.DataAccess.Entity;

namespace Cinema.Services.Interface
{
    public interface IAccountService
    {
        //Получить пользователя
        Task<Account> GetAccount(string email);
        //Создать пользователя
        Task<Account> CreateAccount(Account account);
        //Обновить пользователя
        Task UpdateAccount(Account account);
    }
}
