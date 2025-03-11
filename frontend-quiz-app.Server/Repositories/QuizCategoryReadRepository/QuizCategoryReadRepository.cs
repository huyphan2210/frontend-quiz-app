using frontend_quiz_app.Server.Models;
using frontend_quiz_app.Server.ORM;

namespace frontend_quiz_app.Server.Repositories.QuizCategoryReadRepository
{
    public class QuizCategoryReadRepository : DatabaseReadRepository, IQuizCategoryReadRepository
    {
        public QuizCategoryReadRepository(QuizDbContext context) : base(context) {}

        public List<QuizCategory> GetQuizCategories()
        {
            return Context.QuizCategories.ToList();
        }
    }
}
