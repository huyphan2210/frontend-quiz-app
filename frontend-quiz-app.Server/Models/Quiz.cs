using frontend_quiz_app.Server.DTOs.Enums;

namespace frontend_quiz_app.Server.Models
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public required string Question { get; set; }
        public required string Answer { get; set; }
        public required EQuizCategory Category { get; set;}
    }
}
