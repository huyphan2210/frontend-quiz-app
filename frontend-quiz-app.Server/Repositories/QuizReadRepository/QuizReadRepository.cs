using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.Models;
using frontend_quiz_app.Server.ORM;

namespace frontend_quiz_app.Server.Repositories.QuizReadRepository
{
    public class QuizReadRepository : DatabaseReadRepository, IQuizReadRepository
    {
        public QuizReadRepository(QuizDbContext context) : base(context)
        {
        }

        public List<Quiz> GetQuizzesByCategory(EQuizCategory category)
        {
            return Context.Quizzes.Where(quiz => quiz.Category == category).ToList();
        }
    }
}
