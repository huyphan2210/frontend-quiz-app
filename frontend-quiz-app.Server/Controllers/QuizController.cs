using frontend_quiz_app.Server.DTOs;
using frontend_quiz_app.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace frontend_quiz_app.Server.Controllers
{
    [Route("api/quiz")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly ILogger<QuizController> _logger;
        private readonly IQuizService _quizService;
        public QuizController(ILogger<QuizController> logger, IQuizService quizService)
        {
            _logger = logger;
            _quizService = quizService;
        }


        [Route("categories")]
        [HttpGet(Name = "GetQuizCategories")]
        public IList<QuizCategoryResponse> GetQuizCategories()
        {
            _logger.LogInformation($"{nameof(GetQuizCategories)} triggered");
            return _quizService.GetQuizCategories();
        }
    }
}
