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
            services.AddHttpClient<IPetServiceCategoryRepository, PetServiceCategoryRepository>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });

            services.AddHttpClient<IPetRepository, PetRepository>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });

            services.AddHttpClient<IMessageRepository, MessageRepository>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });

            services.AddHttpClient<IAppointmentRepository, AppointmentRepository>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });
            services.AddHttpClient<IProductRepository, ProductRepository>(client =>

            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });
            services.AddHttpClient<IMessageRepository, MessageRepository>(client =>

            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });
            services.AddHttpClient<IScheduleRepository, ScheduleRepository>(client =>

            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });
            services.AddHttpClient<IRatingRepository, RatingRepository>(client =>

            {
                client.BaseAddress = new Uri("https://localhost:7283");
            });



            #endregion


            #region Services
            // Register other services here if needed.
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IPetServiceService, PetServiceService>();
            services.AddTransient<IPetServiceService, PetServiceService>();
            services.AddTransient<IPetServiceCategoryService, PetServiceCategoryService>();
            services.AddTransient<IRatingService, RatingService>();




            services.AddTransient<IPetBusinessService, PetBusinessService>();
            services.AddTransient<IUserService, UserService>();
            services.AddScoped<IMessageService, MessageService>();

            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IProductService, ProductService>();
            
            services.AddTransient<IScheduleService, ScheduleService>();

            #endregion

            return services;
        }
    }
}
