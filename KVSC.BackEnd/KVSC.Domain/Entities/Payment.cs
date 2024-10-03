namespace KVSC.Domain.Entities;

public class Payment : BaseEntity
{
    public Guid OrderId { get; set; } // Foreign key to Order
    public virtual Order Order { get; set; }

    public Guid SystemTransactionId { get; set; } // Foreign key to SystemTransaction
    public decimal TotalAmount { get; set; }
    public decimal Tax { get; set; }
    public DateTime TransactionDate { get; set; }
}