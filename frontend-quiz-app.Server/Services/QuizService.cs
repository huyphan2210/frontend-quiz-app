using frontend_quiz_app.Server.DTOs;
using frontend_quiz_app.Server.DTOs.Enums;

namespace frontend_quiz_app.Server.Services
{
    public class QuizService : IQuizService
    {
        private readonly ILogger<QuizService> _logger;

        public QuizService(ILogger<QuizService> logger)
        {
            _logger = logger;
        }

        public IList<QuizCategoryResponse> GetQuizCategories()
        {
            _logger.LogInformation($"Running {nameof(GetQuizCategories)}");
            return new List<QuizCategoryResponse>();
        }

        public IList<QuizResponse> GetQuizzesByCategory(EQuizCategory quizCategory)
        {
            _logger.LogInformation($"Running {nameof(GetQuizzesByCategory)}");
            return new List<QuizResponse>();
        }
    }
}
