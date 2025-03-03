using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.DTOs.Request;
using frontend_quiz_app.Server.DTOs.Responses;

namespace frontend_quiz_app.Server.Services
{
    public interface IQuizService
    {
        public IList<QuizCategoryResponse> GetQuizCategories();
        public IList<QuizResponse> GetQuizzesByCategory(EQuizCategory quizCategory, QuizRequest quizRequest);
    }
}
