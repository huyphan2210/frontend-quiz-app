using frontend_quiz_app.Server.DTOs.Enums;

namespace frontend_quiz_app.Server.Models
{
    public class QuizCategory
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string ImgUrl { get; set; }
        public EQuizCategory Type { get; set; }
    }
}
