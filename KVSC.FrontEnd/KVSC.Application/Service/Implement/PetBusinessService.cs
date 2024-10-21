using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.Repositories.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using KVSC.Infrastructure.DTOs.Pet;

namespace KVSC.Application.Service.Implement
{
    public class PetBusinessService : IPetBusinessService
    {
        private readonly IPetRepository _petRepository;

        public PetBusinessService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        
        public async Task<ResponseDto<PetList>> GetPetsByOwnerIdAsync(string token)
        {
            var response = await _petRepository.GetPetsByOwnerIdAsync(token);
            return response;
        }

        public async Task<ResponseDto<PetList>> GetPetList()
        {
            var response = await _petRepository.GetPetList();
            return response;
        }

        public async Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request)
        {
            var response = await _petRepository.AddPetAsync(request);
            return response;
        }

        public async Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request)
        {
            request.Name = string.IsNullOrWhiteSpace(request.Name) ? string.Empty : request.Name;
            request.Color = string.IsNullOrWhiteSpace(request.Color) ? string.Empty : request.Color;
            request.Gender = string.IsNullOrWhiteSpace(request.Gender) ? string.Empty : request.Gender;
            request.ImageUrl = string.IsNullOrWhiteSpace(request.ImageUrl) ? string.Empty : request.ImageUrl;
            request.Note = string.IsNullOrWhiteSpace(request.Note) ? string.Empty : request.Note;
            var response = await _petRepository.UpdatePetAsync(request);
            return response;
        }

        public async Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request)
        {
            var response = await _petRepository.DeletePetAsync(request);
            return response;
        }
    }
}
