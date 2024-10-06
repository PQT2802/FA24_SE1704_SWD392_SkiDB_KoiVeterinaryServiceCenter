using KVSC.Infrastructure.DTOs.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IPetServiceSerivce
    {
        Task<List<PetServiceAdminBoard>> GetPetServiceAdminBoardsAsync();
        Task<List<PetServiceCategory>> GetPetServiceCategoriesAsync(int petTypeId);
        Task<List<PetService>> GetPetServicesAsync(int petCategoryId);
        Task<List<PetService>> GetAllPetServicesAsync();
    }
}
