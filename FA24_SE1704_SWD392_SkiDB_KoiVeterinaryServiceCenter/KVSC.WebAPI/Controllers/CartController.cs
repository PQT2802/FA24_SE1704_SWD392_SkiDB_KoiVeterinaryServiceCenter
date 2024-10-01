using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [HttpPost("add-item")]
        public async Task<IResult> AddItemToCart([FromBody] CartItem cartItem)
        {
            var customerId = GetCustomerIdFromToken(); // Assume a method to extract customer ID from the token
            var result = await _cartService.AddItemToCart(customerId, cartItem);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Item added to cart successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpGet]
        public async Task<IResult> ViewCart()
        {
            var customerId = GetCustomerIdFromToken();
            var result = await _cartService.ViewCart(customerId);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpPut("update-item")]
        public async Task<IResult> UpdateCartItem([FromBody] CartItem updatedCartItem)
        {
            var customerId = GetCustomerIdFromToken();
            var result = await _cartService.UpdateCartItem(customerId, updatedCartItem);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart item updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpDelete("remove-item/{cartItemId}")]
        public async Task<IResult> RemoveItemFromCart(Guid cartItemId)
        {
            var customerId = GetCustomerIdFromToken();
            var result = await _cartService.RemoveItemFromCart(customerId, cartItemId);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Item removed from cart successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        [HttpDelete("clear")]
        public async Task<IResult> ClearCart()
        {
            var customerId = GetCustomerIdFromToken();
            var result = await _cartService.ClearCart(customerId);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart cleared successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // This method is just a placeholder for extracting customer ID from the token
        private Guid GetCustomerIdFromToken()
        {
            // Assume a JWT or session-based token where customerId is stored in claims
            return Guid.Parse(User.Claims.First(c => c.Type == "CustomerId").Value);
        }
    }

}
