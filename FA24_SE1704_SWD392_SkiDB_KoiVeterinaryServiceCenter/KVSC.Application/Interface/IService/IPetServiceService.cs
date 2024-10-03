using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IPetServiceService
    {
        Task<Result> GetPetByIdAsync(Guid id);
        Task<Result> CreatePetAsync(AddPetRequest addPet);
        Task<Result> UpdatePetAsync(Guid id, UpdatePetRequest updatePet);
        Task<Result> DeletePetAsync(Guid id);
        Task<Result> GetAllPetAsync();
    }
}
