using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;

namespace KVSC.Application.Implement.Service
{
    public class CartService : ICartService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CartService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result> AddItemToCart(Guid customerId, CartItem cartItem)
        {
            var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(customerId);

            if (cart == null)
            {
                cart = new Cart
                {
                    CustomerId = customerId,
                    CartItems = new List<CartItem> { cartItem }
                };

                await _unitOfWork.CartRepository.CreateAsync(cart);
            }
            else
            {
                cart.CartItems.Add(cartItem);
            }

            var result = _unitOfWork.Complete();
            if (result == 0) return Result.Failure(Error.Failure("CART_ADD_ERROR", "Could not add item to cart"));

            return Result.SuccessWithObject(cart);
        }

        public async Task<Result> ViewCart(Guid customerId)
        {
            var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(customerId);
            if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

            var totalPrice = cart.CartItems
                .Sum(ci => ci.Product?.Price ?? ci.PetService?.BasePrice ?? 0);

            return Result.SuccessWithObject(new { Cart = cart, TotalPrice = totalPrice });
        }

        public async Task<Result> UpdateCartItem(Guid customerId, CartItem updatedCartItem)
        {
            var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(customerId);
            if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == updatedCartItem.Id);
            if (cartItem == null) return Result.Failure(Error.NotFound("CART_ITEM_NOT_FOUND", "Cart item not found"));

            cartItem.Quantity = updatedCartItem.Quantity;
            cartItem.ServiceId = updatedCartItem.ServiceId;
            cartItem.ProductId = updatedCartItem.ProductId;

            var result = _unitOfWork.Complete();
            if (result == 0) return Result.Failure(Error.Failure("CART_UPDATE_ERROR", "Could not update item in cart"));

            return Result.SuccessWithObject(cart);
        }

        public async Task<Result> RemoveItemFromCart(Guid customerId, Guid cartItemId)
        {
            var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(customerId);
            if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

            var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == cartItemId);
            if (cartItem == null) return Result.Failure(Error.NotFound("CART_ITEM_NOT_FOUND", "Cart item not found"));

            cart.CartItems.Remove(cartItem);
            var result = _unitOfWork.Complete();
            if (result == 0) return Result.Failure(Error.Failure("CART_REMOVE_ERROR", "Could not remove item from cart"));

            return Result.SuccessWithObject(cart);
        }

        public async Task<Result> ClearCart(Guid customerId)
        {
            var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(customerId);
            if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

            cart.CartItems.Clear();
            var result = _unitOfWork.Complete();
            if (result == 0) return Result.Failure(Error.Failure("CART_CLEAR_ERROR", "Could not clear the cart"));

            return Result.SuccessWithObject(cart);
        }
    }

}
