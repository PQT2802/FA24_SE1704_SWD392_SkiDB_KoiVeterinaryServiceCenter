using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {

        public PetRepository(KVSCContext context) : base(context) { }

        public async Task<Pet> GetByIdAsync(Guid Id)
        {
            return await _context.Pets.FirstOrDefaultAsync(p => p.Id == Id);
        }
    }   
}
