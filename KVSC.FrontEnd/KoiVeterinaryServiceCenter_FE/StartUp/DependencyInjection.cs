using KVSC.Application.Service.Implement;
using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.Repositories.Implement;
using KVSC.Infrastructure.Repositories.Interface;

namespace KoiVeterinaryServiceCenter_FE.StartUp
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            #region HttpClient
            services.AddHttpClient<IUserRepository, UserRepository>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });
            services.AddHttpClient<IPetServiceRepository, PetServiceRepository>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });


            #endregion


            #region Services
            // Register other services here if needed.
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IPetServiceService, PetServiceService>();
            #endregion

            return services;
        }
    }
}
