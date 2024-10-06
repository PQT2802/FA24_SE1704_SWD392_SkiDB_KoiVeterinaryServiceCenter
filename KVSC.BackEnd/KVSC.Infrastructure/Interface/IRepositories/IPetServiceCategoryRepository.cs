using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IPetServiceCategoryRepository : IGenericRepository<PetServiceCategory>
    {
      
        public Task<PetServiceCategory> CreateAsync(PetServiceCategory category);
        public Task<int> DeleteAsync(Guid id);
      
    }
}
