using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service
{
    public class PetService : IPropertyNameProvider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PetCategoryId { get; set; }

        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(Id), nameof(Name), nameof(Description), nameof(Price) };
        }
    }
}
