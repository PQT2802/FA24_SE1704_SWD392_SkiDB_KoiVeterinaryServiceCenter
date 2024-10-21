using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet;

namespace KVSC.Application.Service.Interface
{
    public interface IPetBusinessService
    {
        Task<ResponseDto<PetList>> GetPetList();
        Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request);
        Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request);
        Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request);

        Task<ResponseDto<PetList>> GetPetsByOwnerIdAsync(string token);
    }
}