﻿using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using KVSC.Infrastructure.DTOs.Pet.AddPet;
using KVSC.Infrastructure.DTOs.Pet.DeletePet;
using KVSC.Infrastructure.DTOs.Pet.GetPet;
using KVSC.Infrastructure.DTOs.Pet.UpdatePet;
using Microsoft.AspNetCore.Http;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IPetRepository
    {
        Task<ResponseDto<PetList>> GetPetList();
        Task<ResponseDto<AddPetResponse>> AddPetAsync(AddPetRequest request, IFormFile imageFile);
        Task<ResponseDto<UpdatePetResponse>> UpdatePetAsync(UpdatePetRequest request, IFormFile imageFile);
        Task<ResponseDto<DeletePetResponse>> DeletePetAsync(DeletePetRequest request);
        Task<ResponseDto<GetPetResponse>> GetPetDetail(Guid id);
        Task<ResponseDto<PetList>> GetPetsByOwnerIdAsync(string token);
        Task<ResponseDto<PetList>> GetPetsByOwnerAsync(Guid id);
    }
}