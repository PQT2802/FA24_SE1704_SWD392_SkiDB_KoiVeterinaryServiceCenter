using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Pet.AddPetHabitat;
using KVSC.Infrastructure.DTOs.Pet.UpdatePetHabitat;

namespace KVSC.Application.Interface.IService
{
    public interface IPetHabitatService
    {
        Task<Result> GetPetHabitatByIdAsync(Guid id);
        Task<Result> CreatePetHabitatAsync(AddPetHabitatRequest addPetHabitatDto);
        Task<Result> UpdatePetHabitatAsync(Guid id, UpdatePetHabitatRequest updatePetHabitatDto);
        Task<Result> DeletePetHabitatAsync(Guid id);
        Task<Result> GetAllPetHabitatsAsync();
    }
}
