using System.Text.Json.Serialization;

namespace KVSC.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid? UserId { get; set; } // Nullable to allow any user
    public virtual User User { get; set; } // General user reference, not just Customer

    [JsonIgnore]
    public virtual ICollection<CartItem> CartItems { get; set; }
}

