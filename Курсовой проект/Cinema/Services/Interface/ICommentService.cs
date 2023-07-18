using Cinema.DataAccess.Entity;

namespace Cinema.Services.Interface
{
    public interface ICommentService
    {
        //Получить комментарий
        Task<Comment> GetComment(string description);
        //Создать комментарий
        Task<Comment> CreateComment(Comment comment);
        //Обновить комментарий
        Task UpdateComment(Comment comment);
    }
}
