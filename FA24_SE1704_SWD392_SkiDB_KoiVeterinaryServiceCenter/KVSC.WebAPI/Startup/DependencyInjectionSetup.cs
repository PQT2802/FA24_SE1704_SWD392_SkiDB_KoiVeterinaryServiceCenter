
﻿using FirebaseAdmin;
using FluentValidation;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using KVSC.Application.Common.Validator.Pet;
using KVSC.Application.Common.Validator.Product;
using KVSC.Application.Common.Validator.ProductCategory;

﻿using FluentValidation;
using KVSC.Application.Common.Validator.Appointment;
using KVSC.Application.Common.Validator.Pet;
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

using KVSC.Infrastructure.DTOs.User.Register;
using KVSC.Infrastructure.Implement.Repositories;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Common;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.User.Login;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.OpenApi.Models;

namespace KVSC.WebAPI.Startup
{
    public static class DependencyInjectionSetup
    {

        //comr
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {


            var credentialPath = Path.Combine(Directory.GetCurrentDirectory(), "koiveterinaryservicecent-925db-firebase-adminsdk-vus2r-93ba231cea.json");
            try
            {
                FirebaseApp.Create(new AppOptions()
                {
                    Credential = GoogleCredential.FromFile(credentialPath)
                });
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as necessary
                throw new Exception("Failed to initialize Firebase.", ex);
            }

            // Register the Google Cloud Storage client and any Firebase related services
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

            services.AddTransient<IValidator<AddProductRequest>, AddProductValidator>();
            services.AddTransient<IValidator<UpdateProductRequest>, UpdateProductValidator>();
            services.AddTransient<IValidator<AddProductCategoryRequest>, AddProductCategoryValidator>();
            services.AddTransient<IValidator<UpdateProductCategoryRequest>, UpdateProductCategoryValidator>();

            services.AddTransient<IValidator<AddPetServiceRequest>, AddPetServiceValidator>();
            services.AddTransient<IValidator<AddComboServiceRequest>, AddComboServiceValidator>();
            services.AddTransient<IValidator<AddPetServiceCategoryRequest>, AddPetServiceCategoryValidator>();
            services.AddTransient<IValidator<MakeAppointmentForServiceRequest>, MakeAppointmentForServiceValidator>();
            services.AddTransient<IValidator<MakeAppointmentForComboRequest>, MakeAppointmentForComboValidator>();

            //Validator
            #endregion

            #region Repositories
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPetRepository,PetRepository>();

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IFirebaseRepository, FirebaseRepository>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();

            services.AddTransient<IPetServiceRepository,PetServiceRepository>();
            services.AddTransient<IPetServiceCategoryRepository,PetServiceCategoryRepository>();
            services.AddTransient<IPetServiceCategoryRepository, PetServiceCategoryRepository>();
            services.AddTransient<IComboServiceRepository, ComboServiceRepository>();
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();


            #endregion


            #region GenericRepositories
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<Product>, GenericRepository<Product>>();
            services.AddTransient<IGenericRepository<ProductCategoryRepository>, GenericRepository<ProductCategoryRepository>>();
            #endregion



            #region Service
            services.AddTransient<IAuthService, AuthService>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IFirebaseService, FirebaseService>();
            services.AddTransient<IProductCategoryService, ProductCategoryService>();

            services.AddTransient<IPetServiceService, PetServiceService>();
            services.AddTransient<IPetServiceCategoryService, PetServiceCategoryService>();
            services.AddTransient<IComboServiceService, ComboServiceService>();
            services.AddTransient<IAppointmentService, AppointmentService>();

            #endregion





            return services;
        }
    }
}
