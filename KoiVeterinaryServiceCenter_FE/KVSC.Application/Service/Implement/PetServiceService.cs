using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class PetServiceService : IPetServiceSerivce
    {
        public Task<List<Infrastructure.DTOs.Service.PetService>> GetAllPetServicesAsync()
        {
            var services = new List<KVSC.Infrastructure.DTOs.Service.PetService>
    {
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 1, Name = "Grooming", Description = "Full grooming service for pets", Price = 29.99M, PetCategoryId = 1 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 2, Name = "Health Check", Description = "Routine health checks to ensure your pet is in good condition", Price = 49.99M, PetCategoryId = 1 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 3, Name = "Vaccination", Description = "Pet vaccination to keep your pet safe from diseases", Price = 25.00M, PetCategoryId = 2 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 4, Name = "Dental Care", Description = "Pet dental care for healthy teeth", Price = 79.99M, PetCategoryId = 2 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 5, Name = "Spay/Neuter", Description = "Spaying or neutering services for pets", Price = 120.00M, PetCategoryId = 3 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 6, Name = "Microchipping", Description = "Microchipping service for pet identification", Price = 45.00M, PetCategoryId = 3 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 7, Name = "Pet Sitting", Description = "Pet sitting services for short-term care", Price = 20.00M, PetCategoryId = 4 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 8, Name = "Dog Walking", Description = "Dog walking services to keep your dog fit", Price = 15.00M, PetCategoryId = 4 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 9, Name = "Behavior Training", Description = "Training services to correct pet behavior", Price = 100.00M, PetCategoryId = 5 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 10, Name = "Nutrition Counseling", Description = "Nutrition counseling services to optimize pet diets", Price = 60.00M, PetCategoryId = 5 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 11, Name = "Pet Boarding", Description = "Pet boarding service for longer stays", Price = 75.00M, PetCategoryId = 6 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 12, Name = "Luxury Grooming", Description = "Luxury grooming service", Price = 90.00M, PetCategoryId = 6 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 13, Name = "Aquatic Therapy", Description = "Aquatic therapy for pets recovering from injuries", Price = 110.00M, PetCategoryId = 7 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 14, Name = "Hydrotherapy", Description = "Hydrotherapy to improve pet mobility and health", Price = 105.00M, PetCategoryId = 7 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 15, Name = "Exotic Pet Care", Description = "Specialized care services for exotic pets", Price = 150.00M, PetCategoryId = 8 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 16, Name = "Snake Feeding", Description = "Feeding services for pet snakes", Price = 20.00M, PetCategoryId = 8 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 17, Name = "Koi Pond Consultation", Description = "Consultation service for koi pond setup and maintenance", Price = 200.00M, PetCategoryId = 9 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 18, Name = "Koi Fish Health Check", Description = "Health check service for koi fish", Price = 85.00M, PetCategoryId = 9 }
    };

            // Filter services based on the provided petCategoryId
            

            // Return filtered services asynchronously
            return  Task.FromResult(services);
        }

        public Task<List<PetServiceAdminBoard>> GetPetServiceAdminBoardsAsync()
        {
            var list = new List<PetServiceAdminBoard>()
            {
                new PetServiceAdminBoard {Id =1,Name = "test", Description = "test", Price = 100},
                new PetServiceAdminBoard {Id =2,Name = "test", Description = "test", Price = 100},
                new PetServiceAdminBoard {Id =3,Name = "test", Description = "test", Price = 100},
                new PetServiceAdminBoard {Id =4,Name = "test", Description = "test", Price = 100},
                new PetServiceAdminBoard {Id =5,Name = "test", Description = "test", Price = 100},
                new PetServiceAdminBoard {Id =6,Name = "test", Description = "test", Price = 100},
            };
            return Task.FromResult(list);
        }

        public Task<List<PetServiceCategory>> GetPetServiceCategoriesAsync(int petTypeId)
        {
            var allCategories = new List<PetServiceCategory>()
    {
        // Services for Koi (PetTypeId = 1)
        new PetServiceCategory { Id = 1, Name = "Water Quality Check", Description = "Check the water quality of the Koi pond", Icon = "flaticon-water-check", PetTypeId = 1 },
        new PetServiceCategory { Id = 2, Name = "Pond Cleaning", Description = "Full pond cleaning service for Koi fish", Icon = "flaticon-cleaning", PetTypeId = 1 },
        new PetServiceCategory { Id = 3, Name = "Health Check", Description = "Routine health check for Koi fish", Icon = "flaticon-health-check", PetTypeId = 1 },
        new PetServiceCategory { Id = 4, Name = "Health Check demo", Description = "Routine health check for Koi fish", Icon = "flaticon-health-check", PetTypeId = 1 },
        new PetServiceCategory { Id = 5, Name = "Health Check demo", Description = "Routine health check for Koi fish", Icon = "flaticon-health-check", PetTypeId = 1 },

        // Services for Dog (PetTypeId = 2)
        new PetServiceCategory { Id = 4, Name = "Grooming", Description = "Full grooming service for dogs", Icon = "flaticon-grooming", PetTypeId = 2 },
        new PetServiceCategory { Id = 5, Name = "Vaccination", Description = "Vaccination services for dogs", Icon = "flaticon-vaccination", PetTypeId = 2 },
        new PetServiceCategory { Id = 6, Name = "Health Check", Description = "Routine health check for dogs", Icon = "flaticon-health-check", PetTypeId = 2 },

        // Services for Cat (PetTypeId = 3)
        new PetServiceCategory { Id = 7, Name = "Grooming", Description = "Full grooming service for cats", Icon = "flaticon-grooming", PetTypeId = 3 },
        new PetServiceCategory { Id = 8, Name = "Vaccination", Description = "Vaccination services for cats", Icon = "flaticon-vaccination", PetTypeId = 3 },
        new PetServiceCategory { Id = 9, Name = "Health Check", Description = "Routine health check for cats", Icon = "flaticon-health-check", PetTypeId = 3 },

        // Services for Bird (PetTypeId = 4)
        new PetServiceCategory { Id = 10, Name = "Wing Clipping", Description = "Clipping the wings for safety", Icon = "flaticon-wing", PetTypeId = 4 },
        new PetServiceCategory { Id = 11, Name = "Cage Cleaning", Description = "Full cleaning service for bird cages", Icon = "flaticon-cage-cleaning", PetTypeId = 4 },
        new PetServiceCategory { Id = 12, Name = "Health Check", Description = "Routine health check for birds", Icon = "flaticon-health-check", PetTypeId = 4 },

        // Services for Rabbit (PetTypeId = 5)
        new PetServiceCategory { Id = 13, Name = "Grooming", Description = "Full grooming service for rabbits", Icon = "flaticon-grooming", PetTypeId = 5 },
        new PetServiceCategory { Id = 14, Name = "Vaccination", Description = "Vaccination services for rabbits", Icon = "flaticon-vaccination", PetTypeId = 5 },
        new PetServiceCategory { Id = 15, Name = "Health Check", Description = "Routine health check for rabbits", Icon = "flaticon-health-check", PetTypeId = 5 }
    };

            // Filter categories based on the provided petTypeId
            var filteredCategories = allCategories.Where(c => c.PetTypeId == petTypeId).ToList();

            return Task.FromResult(filteredCategories);
        }

        public async Task<List<KVSC.Infrastructure.DTOs.Service.PetService>> GetPetServicesAsync(int petCategoryId)
        {
            // Simulated data source (replace this with a real data source, e.g., a database)
            var services = new List<KVSC.Infrastructure.DTOs.Service.PetService>
    {
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 1, Name = "Grooming", Description = "Full grooming service for pets", Price = 29.99M, PetCategoryId = 1 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 2, Name = "Health Check", Description = "Routine health checks to ensure your pet is in good condition", Price = 49.99M, PetCategoryId = 1 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 3, Name = "Vaccination", Description = "Pet vaccination to keep your pet safe from diseases", Price = 25.00M, PetCategoryId = 2 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 4, Name = "Dental Care", Description = "Pet dental care for healthy teeth", Price = 79.99M, PetCategoryId = 2 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 5, Name = "Spay/Neuter", Description = "Spaying or neutering services for pets", Price = 120.00M, PetCategoryId = 3 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 6, Name = "Microchipping", Description = "Microchipping service for pet identification", Price = 45.00M, PetCategoryId = 3 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 7, Name = "Pet Sitting", Description = "Pet sitting services for short-term care", Price = 20.00M, PetCategoryId = 4 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 8, Name = "Dog Walking", Description = "Dog walking services to keep your dog fit", Price = 15.00M, PetCategoryId = 4 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 9, Name = "Behavior Training", Description = "Training services to correct pet behavior", Price = 100.00M, PetCategoryId = 5 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 10, Name = "Nutrition Counseling", Description = "Nutrition counseling services to optimize pet diets", Price = 60.00M, PetCategoryId = 5 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 11, Name = "Pet Boarding", Description = "Pet boarding service for longer stays", Price = 75.00M, PetCategoryId = 6 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 12, Name = "Luxury Grooming", Description = "Luxury grooming service", Price = 90.00M, PetCategoryId = 6 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 13, Name = "Aquatic Therapy", Description = "Aquatic therapy for pets recovering from injuries", Price = 110.00M, PetCategoryId = 7 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 14, Name = "Hydrotherapy", Description = "Hydrotherapy to improve pet mobility and health", Price = 105.00M, PetCategoryId = 7 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 15, Name = "Exotic Pet Care", Description = "Specialized care services for exotic pets", Price = 150.00M, PetCategoryId = 8 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 16, Name = "Snake Feeding", Description = "Feeding services for pet snakes", Price = 20.00M, PetCategoryId = 8 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 17, Name = "Koi Pond Consultation", Description = "Consultation service for koi pond setup and maintenance", Price = 200.00M, PetCategoryId = 9 },
        new KVSC.Infrastructure.DTOs.Service.PetService { Id = 18, Name = "Koi Fish Health Check", Description = "Health check service for koi fish", Price = 85.00M, PetCategoryId = 9 }
    };

            // Filter services based on the provided petCategoryId
            var filteredServices = services.Where(s => s.PetCategoryId == petCategoryId).ToList();

            // Return filtered services asynchronously
            return await Task.FromResult(filteredServices);
        }
    }
}
