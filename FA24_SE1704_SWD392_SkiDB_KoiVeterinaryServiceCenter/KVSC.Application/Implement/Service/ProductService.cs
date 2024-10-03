using FluentValidation;
using KVSC.Application.Interface.ICommon;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Domain.Entities;
using KVSC.Infrastructure.Interface;
using KVSC.Infrastructure.DTOs.Product.AddProduct;
using System;
using System.Linq;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Common.Message;
using KVSC.Infrastructure.KVSC.Infrastructure.DTOs.Common;
using KVSC.Infrastructure.DTOs.Product.UpdateProduct;
using KVSC.Infrastructure.DTOs.Product.SearchProduct;

namespace KVSC.Application.Implement.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<AddProductRequest> _addProductRequestValidator;
        private readonly IValidator<UpdateProductRequest> _updateProductRequestValidator;

        public ProductService(
            IUnitOfWork unitOfWork,
            IValidator<AddProductRequest> addProductRequestValidator,
            IValidator<UpdateProductRequest> updateProductRequestValidator
        )
        {
            _unitOfWork = unitOfWork;
            _addProductRequestValidator = addProductRequestValidator;
            _updateProductRequestValidator = updateProductRequestValidator;
            
        }

        public async Task<Result> AddProductAsync(AddProductRequest addProductRequest)
        {
            // Validate the AddProductRequest
            var validate = await _addProductRequestValidator.ValidateAsync(addProductRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors
                    .Select(e => (Error)e.CustomState)
                    .ToList();
                return Result.Failures(errors);
            }

            // Check if product name already exists
            var productExists = await _unitOfWork.ProductRepository.ProductNameExistsAsync(addProductRequest.Name);
            if (productExists)
            {
                return Result.Failure(ProductErrorMessage.ProductNameIsExist());
            }
            
            // Create a new product entity
            var product = new Product
            {
                Name = addProductRequest.Name,
                Price = addProductRequest.Price,
                Description = addProductRequest.Description,
                ProductCategoryId = addProductRequest.ProductCategoryId, // Assuming this is in the request
                StockQuantity = addProductRequest.StockQuantity, // Assuming this is in the request, set to 0 if no stock data is provided
                ImageUrl = addProductRequest.ImageUrl // Optional, but set if available
            };

            // Add the product to the database
            var createResult = await _unitOfWork.ProductRepository.CreateProductAsync(product);
            if (createResult == 0) // Adjust according to your repository's CreateAsync method return type
            {
                return Result.Failure(ProductErrorMessage.ProductNameIsExist());
            }

            return Result.SuccessWithObject(createResult);
        }
        // Read (Retrieve a product by ID)
        public async Task<Result> GetProductByIdAsync(Guid productId)
        {
            var product = await _unitOfWork.ProductRepository.GetProductByIdAsync(productId);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotExist());
            }
            return Result.SuccessWithObject(product);
        }
        public async Task<Result> GetProductsAsync(SearchProductRequest request)
        {
            var response = await _unitOfWork.ProductRepository.GetProductsAsync(request);
            if (response.Error != Error.None) // Assuming Error.None means no error
            {
                return Result.Failure(response.Error);
            }
            return Result.SuccessWithObject(response);
        }

        // Update
        public async Task<Result> UpdateProductAsync(UpdateProductRequest updateProductRequest)
        {
            var validate = await _updateProductRequestValidator.ValidateAsync(updateProductRequest);
            if (!validate.IsValid)
            {
                var errors = validate.Errors.Select(e => (Error)e.CustomState).ToList();
                return Result.Failures(errors);
            }

            var product = await _unitOfWork.ProductRepository.GetProductByIdAsync(updateProductRequest.Id);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotExist());
            }

            // Update fields
            if (updateProductRequest.Name != null)
                product.Name = updateProductRequest.Name;

            if (updateProductRequest.Description != null)
                product.Description = updateProductRequest.Description;

            if (updateProductRequest.Price.HasValue)
                product.Price = updateProductRequest.Price.Value;

            if (updateProductRequest.StockQuantity.HasValue)
                product.StockQuantity = updateProductRequest.StockQuantity.Value;

            if (updateProductRequest.ImageUrl != null)
                product.ImageUrl = updateProductRequest.ImageUrl;

            var updateResult = await _unitOfWork.ProductRepository.UpdateProductAsync(product);
            return updateResult == 0
                ? Result.Failure(ProductErrorMessage.ProductUpdateFailed())
                : Result.Success();
        }

        // Delete
        public async Task<Result> DeleteProductAsync(Guid productId)
        {
            var product = await _unitOfWork.ProductRepository.GetProductByIdAsync(productId);
            if (product == null)
            {
                return Result.Failure(ProductErrorMessage.ProductNotFound());
            }

            var deleteResult = await _unitOfWork.ProductRepository.RemoveProductAsync(product);
            return deleteResult ? Result.Success() : Result.Failure(ProductErrorMessage.ProductDeletionFailed());
        }

        
    }
}
