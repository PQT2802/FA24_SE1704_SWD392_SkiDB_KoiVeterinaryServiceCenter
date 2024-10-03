﻿using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.DTOs.Cart;
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

        public async Task<Result> AddItemToCart(AddCartItemDto addCartItemDto)
        {
            try
            {
                var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(null); // Guests or users

                if (cart == null)
                {
                    cart = new Cart
                    {
                        CartItems = new List<CartItem>()
                    };
                    await _unitOfWork.CartRepository.CreateAsync(cart);
                }

                // Iterate through each product and its corresponding quantity
                if (addCartItemDto.ProductQuantities != null && addCartItemDto.ProductQuantities.Count > 0)
                {
                    foreach (var productQuantity in addCartItemDto.ProductQuantities)
                    {
                        // Check if the product is already in the cart, update the quantity if it is
                        var cartItem = cart.CartItems.FirstOrDefault(ci => ci.ProductId == productQuantity.ProductId);
                        if (cartItem != null)
                        {
                            cartItem.Quantity += productQuantity.Quantity; // Increment existing quantity
                        }
                        else
                        {
                            // Add new product to the cart
                            cartItem = new CartItem
                            {
                                ProductId = productQuantity.ProductId,
                                Quantity = productQuantity.Quantity,
                                CartId = cart.Id // Make sure to associate the CartItem with the Cart
                            };
                            // Add cart item to the CartItemRepository
                            await _unitOfWork.CartItemRepository.CreateAsync(cartItem);
                        }
                    }
                }

                var result = _unitOfWork.Complete();
                if (result == 0)
                {
                    return Result.Failure(Error.Failure("CART_ADD_ERROR", "Could not add items to cart"));
                }

                return Result.SuccessWithObject(cart);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("CART_ADD_ERROR", ex.Message));
            }
        }











        public async Task<Result> ViewCart()
        {
            try
            {
                var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(null); // Accessible for users and guests
                if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

                var totalPrice = cart.CartItems.Sum(ci => ci.Product?.Price ?? 0);

                return Result.SuccessWithObject(new { Cart = cart, TotalPrice = totalPrice });
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("CART_VIEW_ERROR", ex.Message));
            }
        }


        public async Task<Result> UpdateCartItem(CartItem updatedCartItem)
        {
            try
            {
                var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(null);
                if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

                var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == updatedCartItem.Id);
                if (cartItem == null) return Result.Failure(Error.NotFound("CART_ITEM_NOT_FOUND", "Cart item not found"));

                cartItem.Quantity = updatedCartItem.Quantity;
                cartItem.ProductId = updatedCartItem.ProductId;

                var result = _unitOfWork.Complete();
                if (result == 0) return Result.Failure(Error.Failure("CART_UPDATE_ERROR", "Could not update item in cart"));

                return Result.SuccessWithObject(cart);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("CART_UPDATE_ERROR", ex.Message));
            }
        }


        public async Task<Result> RemoveItemFromCart(Guid cartItemId)
        {
            try
            {
                var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(null); // Accessible to users and guests
                if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

                var cartItem = cart.CartItems.FirstOrDefault(ci => ci.Id == cartItemId);
                if (cartItem == null) return Result.Failure(Error.NotFound("CART_ITEM_NOT_FOUND", "Cart item not found"));

                cart.CartItems.Remove(cartItem);
                var result = _unitOfWork.Complete();
                if (result == 0) return Result.Failure(Error.Failure("CART_REMOVE_ERROR", "Could not remove item from cart"));

                return Result.SuccessWithObject(cart);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("CART_REMOVE_ERROR", ex.Message));
            }
        }


        public async Task<Result> ClearCart()
        {
            try
            {
                var cart = await _unitOfWork.CartRepository.GetCartWithItemsAsync(null); // Accessible to users and guests
                if (cart == null) return Result.Failure(Error.NotFound("CART_NOT_FOUND", "Cart not found"));

                cart.CartItems.Clear();
                var result = _unitOfWork.Complete();
                if (result == 0) return Result.Failure(Error.Failure("CART_CLEAR_ERROR", "Could not clear the cart"));

                return Result.SuccessWithObject(cart);
            }
            catch (Exception ex)
            {
                return Result.Failure(Error.Failure("CART_CLEAR_ERROR", ex.Message));
            }
        }

    }

}
