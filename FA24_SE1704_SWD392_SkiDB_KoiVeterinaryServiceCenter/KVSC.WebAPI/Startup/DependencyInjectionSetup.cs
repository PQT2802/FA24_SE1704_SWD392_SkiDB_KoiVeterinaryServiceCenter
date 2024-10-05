using FluentValidation;
using KVSC.Application.Common.Validator.Pet;
using KVSC.Application.Common.Validator.User;
using KVSC.Application.Implement.Service;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Validator.Abstract;
using KVSC.Application.KVSC.Application.Common.Validator.User;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Common;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
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

namespace KVSC.WebAPI.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {


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


            //Validator
            #endregion

            #region Repositories
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IPetRepository, PetRepository>();
            services.AddTransient<IPetTypeRepository, PetTypeRepository>();
            services.AddTransient<IPetHabitatRepository, PetHabitatRepository>();
            #endregion


            #region GenericRepositories
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();

            #endregion



            #region Service
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<IPetServiceService, PetServiceService>();
            services.AddTransient<IPetTypeService, PetTypeService>();
            services.AddTransient<IPetHabitatService, PetHabitatService>();

            #endregion





            return services;
        }
    }
}
