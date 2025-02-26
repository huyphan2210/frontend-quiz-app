using frontend_quiz_app.Server.DTOs.Enums;

namespace frontend_quiz_app.Server.DTOs
{
    public class QuizResponse
    {
        public byte? Order { get; set; }
        public required string Question { get; set; }
        public required List<string> Options { get; set; }
        public required string EncodedAnswer { get; set; }
        public required EQuizCategory Category { get; set; }
    }
}
