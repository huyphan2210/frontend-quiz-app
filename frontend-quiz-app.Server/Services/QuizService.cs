using frontend_quiz_app.Server.DTOs;

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
    }
}
