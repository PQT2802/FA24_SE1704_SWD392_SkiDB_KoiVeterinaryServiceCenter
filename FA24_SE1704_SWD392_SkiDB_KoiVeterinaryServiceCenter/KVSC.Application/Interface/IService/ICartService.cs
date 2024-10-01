using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;

namespace KVSC.Application.Interface.IService
{
    public interface ICartService
    {
        Task<Result> AddItemToCart(Guid customerId, CartItem cartItem);
        Task<Result> ViewCart(Guid customerId);
        Task<Result> UpdateCartItem(Guid customerId, CartItem updatedCartItem);
        Task<Result> RemoveItemFromCart(Guid customerId, Guid cartItemId);
        Task<Result> ClearCart(Guid customerId);
    }
}
