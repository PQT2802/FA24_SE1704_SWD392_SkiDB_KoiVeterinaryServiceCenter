using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Cart;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.Api.Controllers
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

        [HttpPost("cart-item")]
        public async Task<IResult> AddItemToCart([FromBody] AddCartItemDto addCartItemDto)
        {
            try
            {
                Result result = await _cartService.AddItemToCart(addCartItemDto);
                return result.IsSuccess
                    ? ResultExtensions.ToSuccessDetails(result, "Item(s) added to cart successfully")
                    : ResultExtensions.ToProblemDetails(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"An error occurred while adding the item to the cart: {ex.Message}");
            }
        }

        [HttpGet("cart-item")]
        public async Task<IResult> ViewCart()
        {
            try
            {
                Result result = await _cartService.ViewCart();
                return result.IsSuccess
                    ? ResultExtensions.ToSuccessDetails(result, "Cart retrieved successfully")
                    : ResultExtensions.ToProblemDetails(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"An error occurred while retrieving the cart: {ex.Message}");
            }
        }

        [HttpPut("cart-item")]
        public async Task<IResult> UpdateCartItem([FromBody] CartItem updatedCartItem)
        {
            try
            {
                Result result = await _cartService.UpdateCartItem(updatedCartItem);
                return result.IsSuccess
                    ? ResultExtensions.ToSuccessDetails(result, "Cart item updated successfully")
                    : ResultExtensions.ToProblemDetails(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"An error occurred while updating the cart item: {ex.Message}");
            }
        }

        [HttpDelete("cart-item/{cartItemId}")]
        public async Task<IResult> RemoveItemFromCart([FromRoute] Guid cartItemId)
        {
            try
            {
                Result result = await _cartService.RemoveItemFromCart(cartItemId);
                return result.IsSuccess
                    ? ResultExtensions.ToSuccessDetails(result, "Item removed from cart successfully")
                    : ResultExtensions.ToProblemDetails(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"An error occurred while removing the item from the cart: {ex.Message}");
            }
        }

        [HttpDelete("cart-item")]
        public async Task<IResult> ClearCart()
        {
            try
            {
                Result result = await _cartService.ClearCart();
                return result.IsSuccess
                    ? ResultExtensions.ToSuccessDetails(result, "Cart cleared successfully")
                    : ResultExtensions.ToProblemDetails(result);
            }
            catch (Exception ex)
            {
                return Results.Problem($"An error occurred while clearing the cart: {ex.Message}");
            }
        }
    }

}
