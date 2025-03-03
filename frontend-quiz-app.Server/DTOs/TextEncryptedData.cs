namespace frontend_quiz_app.Server.DTOs
{
    public class TextEncryptedData
    {
        public required string Encrypted { get; set; }
        public required string Iv { get; set; }
    }
}
