using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Pet
{
    public class PetList
    {
        public Extensions<List<PetData>> Extensions { get; set; }
    }

    public class PetData : IPropertyNameProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public string Color { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }
        public DateTime LastHealthCheck { get; set; }
        public int HealthStatus { get; set; }

        public string Owner { get; set; } // The name of the owner

        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(Name), nameof(Age), nameof(Gender), nameof(Color), nameof(Length), nameof(Weight), nameof(Owner) };
        }
    }
}
