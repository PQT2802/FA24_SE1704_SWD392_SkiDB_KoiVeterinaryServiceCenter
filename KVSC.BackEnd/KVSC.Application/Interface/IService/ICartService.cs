using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Cart;

namespace KVSC.Application.Interface.IService
{

    public interface ICartService
    {

        Task<Result> AddItemToCart(AddCartItemDto addCartItemDto);

        Task<Result> ViewCart();

        Task<Result> UpdateCartItem(CartItem updatedCartItem);

        Task<Result> RemoveItemFromCart(Guid cartItemId);

        Task<Result> ClearCart();
    }

}
