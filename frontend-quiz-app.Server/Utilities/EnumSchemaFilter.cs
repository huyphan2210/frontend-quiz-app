using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace frontend_quiz_app.Server.Utilities
{
    public class EnumSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema schema, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                schema.Type = "string";
                schema.Enum = Enum.GetNames(context.Type)
                    .Select(name => new OpenApiString(name))
                    .Cast<IOpenApiAny>()
                    .ToList();
            }
        }
    }

}
