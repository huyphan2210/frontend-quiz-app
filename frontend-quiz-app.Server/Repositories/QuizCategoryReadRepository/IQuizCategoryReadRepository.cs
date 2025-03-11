using frontend_quiz_app.Server.Models;

namespace frontend_quiz_app.Server.Repositories.QuizCategoryReadRepository
{
    public interface IQuizCategoryReadRepository
    {
        public List<QuizCategory> GetQuizCategories();
    }
}
