using frontend_quiz_app.Server.DTOs;

namespace frontend_quiz_app.Server.Services
{
    public interface IQuizService
    {
        public IList<QuizCategoryResponse> GetQuizCategories();
    }
}
