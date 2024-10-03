namespace KVSC.Domain.Entities;

public class CartItem : BaseEntity
{
    public Guid CartId { get; set; } // Foreign key to Cart

    public int Quantity { get; set; }

    public Guid? ProductId { get; set; } // Foreign key to Product

    public bool IsDeleted { get; set; }
    public Guid? OrderHistoryId { get; set; } // This can refer to a historical order record

    public virtual Product Product { get; set; }
    public virtual Cart Cart { get; set; }
}
