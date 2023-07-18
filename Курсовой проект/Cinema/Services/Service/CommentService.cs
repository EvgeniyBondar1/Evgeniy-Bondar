using Cinema.DataAccess.DbPatterns.Interfaces;
using Cinema.DataAccess.Entity;
using Cinema.Services.Interface;

namespace Cinema.Services.Service
{
    public class CommentService: ServiceConstructor, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
        public async Task<Comment> GetComment(string description)
        {
            IList<Comment> comments = await UnitOfWork.Comments.GetAll();
            return comments.First(a => a.Description == description);

        }

        public async Task<Comment> CreateComment(Comment comment)
        {
            return await UnitOfWork.Comments.Create(comment);
        }

        public async Task UpdateComment(Comment comment)
        {
            await UnitOfWork.Comments.Update(comment);
        }
    }
}
