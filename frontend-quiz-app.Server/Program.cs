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

            const string allowOrigin = "AllowSpecificOrigin";

            var uiUrl = Environment.GetEnvironmentVariable("UI_URL");
            Console.WriteLine("UI_URL: " + uiUrl);
            if (string.IsNullOrEmpty(uiUrl))
            {
                throw new Exception("--- Environment variable UI_URL is empty");
            }

            builder.Services.AddCors((options) =>
            {
                options.AddPolicy(allowOrigin,
                    policy => policy
                        .WithOrigins(uiUrl)
                        .WithHeaders("Access-Control-Allow-Origin")
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });

            AddCustomServices(builder);
            AddCustomRepositories(builder);

            AddDatabaseConnection(builder);

            var app = builder.Build();

            app.UseCors(allowOrigin);

            using (var scope = app.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<QuizDbContext>();
                db.Database.Migrate();
            }

            
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

        private static void AddDatabaseConnection(IHostApplicationBuilder builder)
        {
            var connectionString = string.Empty;
            if (builder.Environment.IsDevelopment())
            {
                connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            }
            else
            {
                var databaseUrl = new Uri(Environment.GetEnvironmentVariable("DATABASE_URL"));
                var userInfo = databaseUrl.UserInfo.Split(':');

                connectionString =
                    $"Host={databaseUrl.Host};Port={databaseUrl.Port};Database={databaseUrl.AbsolutePath.TrimStart('/')};Username={userInfo[0]};Password={userInfo[1]};SSL Mode=Require;Trust Server Certificate=true;";
            }

            builder.Services.AddDbContext<QuizDbContext>(options =>
                options.UseNpgsql(connectionString));
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