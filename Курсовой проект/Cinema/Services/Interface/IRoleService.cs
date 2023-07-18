using Cinema.DataAccess.Entity;

namespace Cinema.Services.Interface
{
    public interface IRoleService
    {
        //Получить роль пользователя
        Task<Role> GetRole(string name);
        //Создать роль пользователя
        Task<Role> CreateRole(Role role);
        //Обновить роль пользователя
        Task UpdateRole(Role role);
    }
}
