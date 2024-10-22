using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Pet.GetPet;

namespace KVSC.Application.Service.Interface
{
    public interface IPetBusinessService
    {
        Task<ResponseDto<PetList>> GetPetList();
        Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request);
        Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request);
        Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request);
        Task<ResponseDto<GetPetResponse>> GetPetDetail(Guid id);

        Task<ResponseDto<PetList>> GetPetsByOwnerIdAsync(string token);
    }
}