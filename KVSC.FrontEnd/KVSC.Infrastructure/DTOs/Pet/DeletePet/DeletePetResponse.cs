using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.DeletePet
{
    public class DeletePetResponse
    {
        public Extensions<DeletePetData> Extensions { get; set; }
    }

    public class DeletePetData
    {
        public Guid Id { get; set; }
    }
}
