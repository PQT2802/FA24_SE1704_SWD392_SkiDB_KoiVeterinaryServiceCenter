using System.Text.Json.Serialization;

namespace KVSC.Domain.Entities;

public class Cart : BaseEntity
{
    public Guid? UserId { get; set; } // Nullable to allow any user
    public User User { get; set; } // General user reference, not just Customer


    // RelationshipsParalle



    [JsonIgnore]

    public ICollection<CartItem> CartItems { get; set; }
}

