using KVSC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IPetServiceCategoryRepository
    {
        public Task<PetServiceCategory> GetByIdAsync(Guid id);
    }
}
