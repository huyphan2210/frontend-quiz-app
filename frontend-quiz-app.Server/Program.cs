using frontend_quiz_app.Server.ORM;
using frontend_quiz_app.Server.Repositories.QuizCategoryReadRepository;
using frontend_quiz_app.Server.Repositories.QuizReadRepository;
using frontend_quiz_app.Server.Services;
using frontend_quiz_app.Server.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using Swashbuckle.AspNetCore.Swagger;

namespace frontend_quiz_app.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c => { c.SchemaFilter<EnumSchemaFilter>(); });

            AddCustomServices(builder);
            AddCustomRepositories(builder);

            AddSqlLiteConnection(builder);

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                GenerateSwagger(app);
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }

        private static void AddCustomServices(IHostApplicationBuilder builder)
        {
            builder.Services.AddScoped<IQuizService, QuizService>();
        }

        private static void AddCustomRepositories(IHostApplicationBuilder builder)
        {
            builder.Services.AddScoped<IQuizReadRepository, QuizReadRepository>();
            builder.Services.AddScoped<IQuizCategoryReadRepository, QuizCategoryReadRepository>();
        }

        private static void AddSqlLiteConnection(IHostApplicationBuilder builder)
        {
            builder.Services.AddDbContext<QuizDbContext>(options =>
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
        }

        private static void GenerateSwagger(WebApplication app)
        {
            var filePath = Path.Combine(app.Environment.ContentRootPath, "swagger.json");
            var swaggerProvider = app.Services.GetRequiredService<ISwaggerProvider>();

            using var writer = new StreamWriter(filePath);
            var swaggerDoc = swaggerProvider.GetSwagger("v1");
            swaggerDoc.SerializeAsJson(writer.BaseStream, new Microsoft.OpenApi.OpenApiSpecVersion());
        }
    }
}