using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Pet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class PetService : IPetService
    {
        public Task<List<PetType>> GetPetTypeAsync()
        {
            var listPet = new List<PetType>()
    {
        new PetType { PetTypeId = 1, PetName = "Koi" },
        new PetType { PetTypeId = 2, PetName = "Dog" },
        new PetType { PetTypeId = 3, PetName = "Cat" },
        new PetType { PetTypeId = 4, PetName = "Bird" },
        new PetType { PetTypeId = 5, PetName = "Rabbit" }
    };

            return Task.FromResult(listPet);
        }

    }
}
