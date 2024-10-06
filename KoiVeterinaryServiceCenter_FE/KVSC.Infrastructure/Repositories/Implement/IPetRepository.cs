using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Implement
{
    public interface IPetRepository
    {
        Task<ResponseDto<List<PetType>>> GetListPetTypeAsync();
    }
}
