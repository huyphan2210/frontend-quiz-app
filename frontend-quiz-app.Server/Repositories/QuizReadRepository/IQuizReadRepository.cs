using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.Models;

namespace frontend_quiz_app.Server.Repositories.QuizReadRepository
{
    public interface IQuizReadRepository
    {
        public List<Quiz> GetQuizzesByCategory(EQuizCategory category);
    }
}
