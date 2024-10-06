using KVSC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IComboServiceRepository : IGenericRepository<ComboService>
    {
        public Task<ComboService> CreateAsync(ComboService comboService);
        public Task<IEnumerable<ComboService>> GetAllComboAsync();
     
        public Task<ComboService> GetComboByIdAsync(Guid id);
        public Task<int> UpdateAsync(ComboService comboService);
      
        public Task<int> DeleteAsync(Guid id);
        
    }
}
