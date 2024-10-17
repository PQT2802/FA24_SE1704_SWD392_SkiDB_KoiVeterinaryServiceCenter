using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.UpdatePet
{
    public class UpdatePetResponse
    {
        public Extensions<UpdatePetData> Extensions { get; set; }
    }

    public class UpdatePetData
    {
        public Guid Id { get; set; }
    }
}
