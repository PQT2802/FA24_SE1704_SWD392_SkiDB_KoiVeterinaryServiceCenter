using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class PetServiceCategoryRepository : GenericRepository<PetServiceCategory>, IPetServiceCategoryRepository
    {
        public PetServiceCategoryRepository(KVSCContext context) : base(context) { }

        // Kiểm tra xem danh mục dịch vụ có tồn tại không
        public async Task<PetServiceCategory> GetByIdAsync(Guid id)
        {
            return await _context.PetServiceCategories.FindAsync(id);
        }
    }
}
