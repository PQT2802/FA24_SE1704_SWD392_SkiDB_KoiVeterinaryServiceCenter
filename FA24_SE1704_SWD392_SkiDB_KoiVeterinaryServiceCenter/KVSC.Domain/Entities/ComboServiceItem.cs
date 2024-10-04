using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class ComboServiceItem
    {
        public Guid Id { get; set; } // Unique identifier for the combo service item
        public Guid ComboServiceId { get; set; } // Foreign key to ComboService
        public Guid PetServiceId { get; set; } // Foreign key to PetService

        // Relationships
        public ComboService ComboService { get; set; } // Navigation property to ComboService
        public PetService PetService { get; set; } // Navigation property to PetService
    }
}
