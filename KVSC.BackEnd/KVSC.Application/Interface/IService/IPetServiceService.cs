using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Pet.AddPetService;
using KVSC.Infrastructure.DTOs.PetService;
using KVSC.Infrastructure.DTOs.PetService.UpdatePetService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IPetServiceService
    {
        public Task<Result> CreatePetServiceAsync(AddPetServiceRequest petServiceValidator);
        public Task<Result> GetAllPetServicesAsync();
        public Task<Result> GetPetServiceByIdAsync(Guid id);
        public Task<Result> UpdatePetServiceAsync(UpdatePetServiceRequest updatePetServiceRequest);
        public Task<Result> DeletePetServiceAsync(Guid id);
        Task<Result> UploadImageAsync(UploadImageRequest request);
    }
}
