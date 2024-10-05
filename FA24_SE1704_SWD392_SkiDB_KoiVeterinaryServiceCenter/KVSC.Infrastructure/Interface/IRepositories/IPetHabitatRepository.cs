using KVSC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IPetHabitatRepository
    {
        Task<PetHabitat> GetPetHabitatByIdAsync(Guid id);
        Task<List<PetHabitat>> GetAllPetHabitatsAsync();
        Task<PetHabitat> CreatePetHabitatAsync(PetHabitat petHabitat);
        Task<int> UpdatePetHabitatAsync(PetHabitat petHabitat);
        Task<int> DeletePetHabitatAsync(Guid id);
    }
}
