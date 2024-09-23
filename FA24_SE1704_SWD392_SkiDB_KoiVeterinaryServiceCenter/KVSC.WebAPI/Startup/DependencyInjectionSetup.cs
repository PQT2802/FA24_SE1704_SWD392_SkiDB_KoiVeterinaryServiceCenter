using FluentValidation;
using KVSC.Application.Implement.Service;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Validator.Abstract;
using KVSC.Application.KVSC.Application.Common.Validator.User;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using Microsoft.AspNetCore.Identity;
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

            });
            //services.AddTransient<IValidator<User>, UserValidator>();
            

            

            #region Common
            //Common
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            //Comon
            #endregion

            #region Validator
            //Validator
            services.AddTransient<IValidator<LoginRequest>, LoginValidator>();


            //Validator
            #endregion

            #region Repositories

            #endregion

            #region Service
            services.AddTransient<IAuthService, AuthService>();
            #endregion





            return services;
        }
    }
}
