using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IPetRepository
    {
        Task<ResponseDto<PetList>> GetPetList();
        Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request);
        Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request);
        Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request);
    }
}
