using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.UpdatePetType
{
    public class UpdatePetTypeRequest
    {
        public string GeneralType { get; set; }
        public string SpecificType { get; set; }
        public Guid PetHabitatId { get; set; }
    }
}
