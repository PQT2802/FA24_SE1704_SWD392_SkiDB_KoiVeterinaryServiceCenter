namespace KVSC.Infrastructure.DTOs.Cart
{
    public class AddCartItemDto
    {
        public List<ProductQuantityDto> ProductQuantities { get; set; } // List of product IDs with corresponding quantities
    }

    public class ProductQuantityDto
    {
        public Guid ProductId { get; set; } // Product ID
        public int Quantity { get; set; } // Quantity for this specific product
    }

}
