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

        [HttpPost("add-item")]
        public async Task<IResult> AddItemToCart([FromBody] AddCartItemDto addCartItemDto)
        {
            Result result = await _cartService.AddItemToCart(addCartItemDto);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Item(s) added to cart successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        [HttpGet("view")]
        public async Task<IResult> ViewCart()
        {
            Result result = await _cartService.ViewCart();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        [HttpPut("update-item")]
        public async Task<IResult> UpdateCartItem([FromBody] CartItem updatedCartItem)
        {
            Result result = await _cartService.UpdateCartItem(updatedCartItem);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart item updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        [HttpDelete("remove-item/{cartItemId}")]
        public async Task<IResult> RemoveItemFromCart([FromRoute] Guid cartItemId)
        {
            Result result = await _cartService.RemoveItemFromCart(cartItemId);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Item removed from cart successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        [HttpDelete("clear")]
        public async Task<IResult> ClearCart()
        {
            Result result = await _cartService.ClearCart();
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Cart cleared successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

    }
}
