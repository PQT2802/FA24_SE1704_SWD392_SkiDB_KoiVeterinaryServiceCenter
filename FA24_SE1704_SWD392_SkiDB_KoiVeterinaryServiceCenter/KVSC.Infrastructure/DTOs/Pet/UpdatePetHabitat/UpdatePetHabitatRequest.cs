using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.UpdatePetHabitat
{
    public class UpdatePetHabitatRequest
    {
        public Guid Id { get; set; }
        public string HabitatType { get; set; }
    }
}
