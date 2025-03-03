using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.DTOs.Request;
using frontend_quiz_app.Server.DTOs.Responses;
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

        [HttpGet("categories", Name = "GetQuizCategories")]
        public ActionResult<IList<QuizCategoryResponse>> GetQuizCategories()
        {
            _logger.LogInformation($"{nameof(GetQuizCategories)} triggered");
            return Ok(_quizService.GetQuizCategories());
        }

        [HttpPost(Name = "GetQuizzesByCategory")]
        public ActionResult<IList<QuizResponse>> GetQuizzesByCategory([FromQuery] EQuizCategory category, QuizRequest quizRequest)
        {
            _logger.LogInformation($"{nameof(GetQuizzesByCategory)} triggered");
            return Ok(_quizService.GetQuizzesByCategory(category, quizRequest));
        }
    }
}
