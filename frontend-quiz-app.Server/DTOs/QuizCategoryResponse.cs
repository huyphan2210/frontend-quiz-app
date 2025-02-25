using frontend_quiz_app.Server.DTOs.Enums;
using System.Text.Json.Serialization;

namespace frontend_quiz_app.Server.DTOs
{
    public class QuizCategoryResponse
    {
        public required string Name { get; set; }
        public required string ImgUrl { get; set; }
        public string? ImgBackgroundColor { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public EQuizCategory Type { get; set; }
    }
}
