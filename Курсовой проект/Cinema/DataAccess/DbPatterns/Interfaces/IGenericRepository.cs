namespace Cinema.DataAccess.DbPatterns.Interfaces
{

    #region IGenericRepository


    #endregion
    public interface IGenericRepository<T>
    {
        //Создать новую запись в таблице БД
        Task<T> Create(T t);
        //Обновить запись в таблице БД
        Task Update(T t);
        //Удалить запись в таблице БД
        Task Delete(T t);
        //Получить определенную запись по Id из БД
        Task<T> Get(Guid id);
        //Получить все записи из таблицы БД
        Task<IList<T>> GetAll();
    }
}
