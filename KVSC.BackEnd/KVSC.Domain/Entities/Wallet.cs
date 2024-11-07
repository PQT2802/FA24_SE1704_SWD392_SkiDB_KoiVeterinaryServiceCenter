using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KVSC.Domain.Entities
{
    public class Wallet : BaseEntity
    {
        public Guid UserId { get; set; }  // Foreign key to the User entity
        public decimal Amount { get; set; }
        [JsonIgnore]
        public virtual User User { get; set; }
    }
}
