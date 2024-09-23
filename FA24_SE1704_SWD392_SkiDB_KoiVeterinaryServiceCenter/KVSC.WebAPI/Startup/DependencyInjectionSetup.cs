using Microsoft.OpenApi.Models;

namespace KVSC.WebAPI.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(option =>
            {
                option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
                option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please enter a valid token",
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    BearerFormat = "JWT",
                    Scheme = "Bearer"
                });
                option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
                // Add custom document filter
                //  option.DocumentFilter<CustomDocumentFilter>();
                // option.OperationFilter<FileUploadOperationFilter>();
                // option.SchemaFilter<SimpleEnumSchemaFilter>();
                // option.OperationFilter<SwaggerEnumOperationFilter>();
            });








            //services.AddTransient<IValidator<User>, UserValidator>();



            return services;
        }
    }
}
