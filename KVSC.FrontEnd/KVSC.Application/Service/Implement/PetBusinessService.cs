using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.Repositories.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Pet.GetPet;

namespace KVSC.Application.Service.Implement
{
    public class PetBusinessService : IPetBusinessService
    {
        private readonly IPetRepository _petRepository;

        public PetBusinessService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public async Task<ResponseDto<PetList>> GetPetList()
        {
            var response = await _petRepository.GetPetList();
            return response;
        }

        public async Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request)
        {
            request.ImageUrl = string.IsNullOrWhiteSpace(request.ImageUrl) ? string.Empty : request.ImageUrl;
            var response = await _petRepository.AddPetAsync(request);
            return response;
        }

        public async Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request)
        {
            request.ImageUrl = string.IsNullOrWhiteSpace(request.ImageUrl) ? string.Empty : request.ImageUrl;
            var response = await _petRepository.UpdatePetAsync(request);
            return response;
        }

        public async Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request)
        {
            var response = await _petRepository.DeletePetAsync(request);
            return response;
        }
        public async Task<ResponseDto<GetPetResponse>> GetPetDetail(Guid id)
        {
            var response = await _petRepository.GetPetDetail(id);
            return response;
        }

    }
}
