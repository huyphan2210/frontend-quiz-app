namespace frontend_quiz_app.Server.DTOs
{
    public class QuizResponse
    {
        public required string Question { get; set; }
        public required string EncodedAnswer { get; set;}
    }
}
