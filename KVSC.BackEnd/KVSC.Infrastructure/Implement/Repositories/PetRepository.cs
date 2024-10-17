using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using Microsoft.EntityFrameworkCore;

namespace KVSC.Infrastructure.Implement.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(KVSCContext context) : base(context)
        {
        }

        public async Task<Pet> GetPetByIdAsync(Guid id)
        {
            return await _context.Pets.FirstOrDefaultAsync(s => s.Id == id && !s.IsDeleted);
        }

        public async Task<List<Pet>> GetAllPetAsync()
        {
            return await _context.Pets.Where(s => !s.IsDeleted).ToListAsync();
        }

        public async Task<Pet> CreatePetAsync(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();
            return pet;
        }

        public async Task<int> UpdatePetAsync(Pet pet)
        {
            _context.Pets.Update(pet);
            return await _context.SaveChangesAsync();
        }

        //xoa luon pet
        public async Task<int> DeletePetAsync(Guid id)
        {
            var pet = await GetPetByIdAsync(id);
            if (pet != null)
            {
                _context.Pets.Remove(pet);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        //xoa nhe pet
        public async Task<int> SoftDeletePetAsync(Guid id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet != null)
            {
                pet.IsDeleted = true;
                _context.Pets.Update(pet);
                return await _context.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<List<Pet>> GetAllPetsByOwnerIdAsync(Guid ownerId)
        {
            return await _context.Pets
            .Where(p => p.OwnerId == ownerId && !p.IsDeleted)
            .ToListAsync();
        }
    }
}