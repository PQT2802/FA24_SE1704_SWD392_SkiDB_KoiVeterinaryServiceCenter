using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddPetType;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IPetTypeService
    {
        Task<Result> GetPetTypeByIdAsync(Guid id);
        Task<Result> GetAllPetTypesAsync();
        Task<Result> CreatePetTypeAsync(AddPetTypeRequest addPetTypeDto);
        Task<Result> UpdatePetTypeAsync(Guid id, UpdatePetTypeRequest updatePetTypeDto);
        Task<Result> DeletePetTypeAsync(Guid id);
    }
}
