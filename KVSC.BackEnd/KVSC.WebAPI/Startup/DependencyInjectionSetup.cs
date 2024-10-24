using FirebaseAdmin;
using FluentValidation;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using KVSC.Application.Common.Validator.Pet;
using KVSC.Application.Common.Validator.Product;
using KVSC.Application.Common.Validator.ProductCategory;
using KVSC.Application.Common.Validator.Appointment;
using KVSC.Application.Common.Validator.PetService;
using KVSC.Application.Common.Validator.User;
using KVSC.Application.Implement.Service;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Validator.Abstract;
using KVSC.Application.KVSC.Application.Common.Validator.User;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Common;
using KVSC.Infrastructure.DTOs.Appointment.MakeAppointment;
using KVSC.Infrastructure.DTOs.Pet.AddComboService;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Product.AddProduct;
using KVSC.Infrastructure.DTOs.Product.UpdateProduct;
using KVSC.Infrastructure.DTOs.ProductCategory.AddProductCategory;
using KVSC.Infrastructure.DTOs.ProductCategory.UpdateProductCategory;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.DTOs.Pet.AddPetHabitat;
using KVSC.Infrastructure.DTOs.Pet.AddPetType;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetHabitat;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetType;
using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Implement.Repositories;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;
using KVSC.Application.KVSC.Application.Implement.Service;
using KVSC.Infrastructure.DTOs.PetServiceCategory.AddPetServiceCategroy;
using KVSC.Application.Common.Validator.PetServiceCategory;
using KVSC.Application.Common.Validator.ComboService;
using KVSC.Infrastructure.DTOs.PetService.UpdatePetService;
using KVSC.Infrastructure.DTOs.PetServiceCategory.UpdatePetServiceCategory;
using KVSC.Infrastructure.DTOs.ComboService.UpdateComboService;
using KVSC.Application.Common.Validator.ServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.AddServiceReport;
using KVSC.Infrastructure.DTOs.ServiceReport.UpdateServiceReport;
using KVSC.Infrastructure.DTOs.Schedule;
using KVSC.Application.Common.Validator.VeterinarianSchedule;
using KVSC.Infrastructure.DTOs.User.UpdateUser;
using KVSC.Infrastructure.DTOs.User.AddUser;
using KVSC.Infrastructure.DTOs.Rating.AddRating;
using KVSC.Application.Common.Validator.Rating;
using KVSC.Infrastructure.DTOs.Rating.UpdateRating;

namespace KVSC.WebAPI.Startup
{
    public static class DependencyInjectionSetup
    {
        //comr
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            var credentialPath = Path.Combine(Directory.GetCurrentDirectory(), "Keys",
                "koiveterinaryservicecent-925db-firebase-adminsdk-vus2r-0a84673789.json");

            try
            {
                // Initialize Firebase with the credentials from the JSON file
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(credentialPath)
                });
            }
            catch (Exception ex)
            {
                // Log or handle the exception as necessary
                throw new Exception("Failed to initialize Firebase.", ex);
            }

            // Register the Google Cloud Storage client and Firebase related services
            services.AddSingleton(StorageClient.Create(GoogleCredential.FromFile(credentialPath)));


            #region Common

            //Common
            services.AddTransient<IPasswordHasher, PasswordHasher>();
            services.AddTransient<UnitOfWork>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            //Comon

            #endregion

            #region Validator

            //Validator
            services.AddTransient<IValidator<LoginRequest>, LoginValidator>();
            services.AddTransient<IValidator<RegisterRequest>, RegisterValidator>();
            services.AddTransient<IValidator<AddPetRequest>, AddPetValidator>();
            services.AddTransient<IValidator<UpdatePetRequest>, UpdatePetvalidator>();
            services.AddTransient<IValidator<AddPetTypeRequest>, AddPetTypeValidator>();
            services.AddTransient<IValidator<UpdatePetTypeRequest>, UpdatePetTypeValidator>();
            services.AddTransient<IValidator<AddPetHabitatRequest>, AddPetHabitatValidator>();
            services.AddTransient<IValidator<UpdatePetHabitatRequest>, UpdatePetHabitatValidator>();

            services.AddTransient<IValidator<AddProductRequest>, AddProductValidator>();
            services.AddTransient<IValidator<UpdateProductRequest>, UpdateProductValidator>();
            services.AddTransient<IValidator<AddProductCategoryRequest>, AddProductCategoryValidator>();
            services.AddTransient<IValidator<UpdateProductCategoryRequest>, UpdateProductCategoryValidator>();

            services.AddTransient<IValidator<AddPetServiceRequest>, AddPetServiceValidator>();
            services.AddTransient<IValidator<UpdatePetServiceRequest>, UpdatePetServiceValidator>();    

            services.AddTransient<IValidator<AddComboServiceRequest>, AddComboServiceValidator>();
            services.AddTransient<IValidator<UpdateComboServiceRequest>, UpdateComboServiceValidator>();

            services.AddTransient<IValidator<AddPetServiceCategoryRequest>, AddPetServiceCategoryValidator>();
            services.AddTransient<IValidator<UpdatePetServiceCategoryRequest>, UpdatePetServiceCategoryValidator>();

            services.AddTransient<IValidator<MakeAppointmentForServiceRequest>, MakeAppointmentForServiceValidator>();
            services.AddTransient<IValidator<MakeAppointmentForComboRequest>, MakeAppointmentForComboValidator>();
            services.AddTransient<IValidator<AddServiceReportRequest>, AddServiceReportValidator>();
            services.AddTransient<IValidator<UpdateServiceReportRequest>, UpdateServiceReportValidator>();

            services.AddTransient<IValidator<RegisterScheduleRequest>, RegisterScheduleValidator>();

            services.AddTransient<IValidator<UpdateUserRequest>, UpdateUserValidator>();
            services.AddTransient<IValidator<AddUserRequest>, AddUserValidator>();

            services.AddTransient<IValidator<AddRatingRequest>, AddRatingValidator>();
            services.AddTransient<IValidator<UpdateRatingRequest>, UpdateRatingValidator>();

            //Validator

            #endregion

            #region Repositories

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPetRepository, PetRepository>();

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IFirebaseRepository, FirebaseRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IPetServiceRepository, PetServiceRepository>();
            services.AddTransient<IPetServiceCategoryRepository, PetServiceCategoryRepository>();
            services.AddTransient<IPetServiceCategoryRepository, PetServiceCategoryRepository>();
            services.AddTransient<IComboServiceRepository, ComboServiceRepository>();
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();

            services.AddScoped<IMessageRepository, MessageRepository>();

            services.AddTransient<IPrescriptionRepository, PrescriptionRepository>();
            services.AddTransient<IServiceReportRepository, ServiceReportRepository>();
            services.AddTransient<IVeterinarianScheduleRepository, VeterinarianScheduleRepository>();

            
            services.AddTransient<IRatingRepository, RatingRepository>();


            #endregion


            #region GenericRepositories

            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();
            services.AddTransient<IGenericRepository<PrescriptionRepository>, GenericRepository<PrescriptionRepository>>();
            services.AddTransient<IGenericRepository<VeterinarianScheduleRepository>, GenericRepository<VeterinarianScheduleRepository>>();
            services
                .AddTransient<IGenericRepository<ProductCategoryRepository>,
                    GenericRepository<ProductCategoryRepository>>();

            #endregion


            #region Service

            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IPetBusinessService, PetBusinessService>();
            services.AddTransient<IPetTypeService, PetTypeService>();
            services.AddTransient<IPetHabitatService, PetHabitatService>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IFirebaseService, FirebaseService>();
            services.AddTransient<IProductCategoryService, ProductCategoryService>();

            services.AddTransient<IPetServiceService, PetServiceService>();
            services.AddTransient<IPetServiceCategoryService, PetServiceCategoryService>();
            services.AddTransient<IComboServiceService, ComboServiceService>();
            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<ITokenService, TokenService>();
            services.AddTransient<IServiceReportService, ServiceReportService>();
            services.AddTransient<IVeterinarianScheduleService, VeterinarianScheduleService>();

            services.AddScoped<IMessageService, MessageService>();

            services.AddTransient<IUserService, UserService>();

            services.AddTransient<IRatingService, RatingService>();


            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            #endregion


            return services;
        }
    }
}