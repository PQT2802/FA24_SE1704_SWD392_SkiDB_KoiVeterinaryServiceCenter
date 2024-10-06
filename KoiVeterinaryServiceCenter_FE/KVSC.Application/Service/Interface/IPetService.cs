using KVSC.Infrastructure.DTOs.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IPetService
    {
        Task<List<PetType>> GetPetTypeAsync();

    }
}
