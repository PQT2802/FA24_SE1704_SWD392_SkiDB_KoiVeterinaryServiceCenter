using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Pet
    {
        public Guid PetId { get; set; }
        public string PetName { get; set; }
        public double Age { get; set; }
        public string Color { get; set; }
    }
}
