using frontend_quiz_app.Server.Models;
using frontend_quiz_app.Server.ORM;

namespace frontend_quiz_app.Server.Repositories
{
    public class DatabaseReadRepository
    {
        protected readonly QuizDbContext Context;

        public DatabaseReadRepository(QuizDbContext context)
        {
            Context = context;
        }
    }
}
