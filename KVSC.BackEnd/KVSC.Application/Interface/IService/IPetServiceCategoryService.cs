using FluentValidation;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.PetServiceCategory.AddPetServiceCategroy;
using KVSC.Infrastructure.DTOs.PetServiceCategory.UpdatePetServiceCategory;
using KVSC.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IPetServiceCategoryService
    {
        public Task<Result> CreatePetServiceCategoryAsync(AddPetServiceCategoryRequest addPetServiceCategory);


        public Task<Result> GetAllPetServiceCategoriesAsync();


        public Task<Result> GetPetServiceCategoryByIdAsync(Guid id);


        public Task<Result> UpdatePetServiceCategoryAsync(UpdatePetServiceCategoryRequest updatePetServiceRequest);
        public Task<Result> DeletePetServiceCategoryAsync(Guid id);
      
    }
}
