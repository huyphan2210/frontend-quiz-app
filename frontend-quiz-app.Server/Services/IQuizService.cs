using frontend_quiz_app.Server.DTOs;
using frontend_quiz_app.Server.DTOs.Enums;

namespace frontend_quiz_app.Server.Services
{
    public interface IQuizService
    {
        public IList<QuizCategoryResponse> GetQuizCategories();
        public IList<QuizResponse> GetQuizzesByCategory(EQuizCategory quizCategory);
    }
}
