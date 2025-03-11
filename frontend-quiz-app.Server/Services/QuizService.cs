using frontend_quiz_app.Server.DTOs;
using frontend_quiz_app.Server.DTOs.Enums;
using frontend_quiz_app.Server.DTOs.Request;
using frontend_quiz_app.Server.DTOs.Responses;
using frontend_quiz_app.Server.Repositories.QuizCategoryReadRepository;
using frontend_quiz_app.Server.Repositories.QuizReadRepository;
using System.Security.Cryptography;
using System.Text;

namespace frontend_quiz_app.Server.Services
{
    public class QuizService : IQuizService
    {
        private readonly IQuizReadRepository _quizReadRepository;
        private readonly IQuizCategoryReadRepository _quizCategoryReadRepository;
        private readonly ILogger<QuizService> _logger;

        private readonly IDictionary<EQuizCategory, string> _categoryBackgroundColors;

        public QuizService(IQuizReadRepository quizReadRepository,
            IQuizCategoryReadRepository quizCategoryReadRepository, ILogger<QuizService> logger)
        {
            _quizReadRepository = quizReadRepository;
            _quizCategoryReadRepository = quizCategoryReadRepository;

            _categoryBackgroundColors = new Dictionary<EQuizCategory, string>
            {
                { EQuizCategory.Html, "#fff1e9"},
                { EQuizCategory.Css, "#e0fdef"},
                { EQuizCategory.JavaScript, "#ebf0ff" },
                { EQuizCategory.Accessibility, "#f6e7ff" }
            };

            _logger = logger;
        }

        public IList<QuizCategoryResponse> GetQuizCategories()
        {
            _logger.LogInformation($"Running {nameof(GetQuizCategories)}");
            var categories = _quizCategoryReadRepository.GetQuizCategories().Select(category => new QuizCategoryResponse
            {
                Name = category.Name,
                ImgUrl = category.ImgUrl,
                Type = category.Type,
                ImgBackgroundColor = _categoryBackgroundColors[category.Type],
            }).ToList();

            return categories;
        }

        public IList<QuizResponse> GetQuizzesByCategory(EQuizCategory quizCategory, QuizRequest quizRequest)
        {
            _logger.LogInformation($"Running {nameof(GetQuizzesByCategory)}");

            var quizzes = _quizReadRepository.GetQuizzesByCategory(quizCategory).Select((quiz, index) =>
                new QuizResponse
                {
                    Category = quiz.Category,
                    EncodedAnswer = EncryptTextUsingKey(quiz.Answer, quizRequest.EncryptKeyBase64),
                    Options = quiz.Options,
                    Question = quiz.Question,
                    Order = (byte?)(index + 1)
                }).ToList();

            return quizzes;
        }

        private static TextEncryptedData EncryptTextUsingKey(string text, string encryptKey)
        {
            var key = Convert.FromBase64String(encryptKey);
            var iv = new byte[AesGcm.NonceByteSizes.MaxSize];
            RandomNumberGenerator.Fill(iv);

            var plaintextBytes = Encoding.UTF8.GetBytes(text);
            var encryptedData = new byte[plaintextBytes.Length];
            var tag = new byte[AesGcm.TagByteSizes.MaxSize];

            using (var aes = new AesGcm(key, AesGcm.TagByteSizes.MaxSize))
            {
                aes.Encrypt(iv, plaintextBytes, encryptedData, tag);
            }

            encryptedData = encryptedData.Concat(tag).ToArray();

            CryptographicOperations.ZeroMemory(key);

            return new TextEncryptedData
            {
                Encrypted = Convert.ToBase64String(encryptedData),
                Iv = Convert.ToBase64String(iv),
            };
        }
    }
}