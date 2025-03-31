using frontend_quiz_app.Server.DTOs.Enums;

namespace frontend_quiz_app.Server.Models
{
    public class Quiz : BaseModel
    {
        public required string Question { get; set; }
        public required string OptionsJson { get; set; }
        public required string Answer { get; set; }
        public required EQuizCategory Category { get; set;}
        public DateTime CreatedAt { get; set; }
    }
}
