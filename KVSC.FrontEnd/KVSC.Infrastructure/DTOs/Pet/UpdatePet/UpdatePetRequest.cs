using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet.UpdatePet
{
    public class UpdatePetRequest
    {
        public Guid Id { get; set; } // The ID of the pet to update
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public DateTime LastHealthCheck { get; set; }
        public string Note { get; set; }
    }
}
