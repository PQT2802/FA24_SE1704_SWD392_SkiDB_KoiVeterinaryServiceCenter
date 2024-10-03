using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Product.AddProduct;
using KVSC.Infrastructure.DTOs.Product.SearchProduct;
using KVSC.Infrastructure.DTOs.Product.UpdateProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // Get product by ID
        [HttpGet("{id}")]
        public async Task<IResult> GetProductById(Guid id)
        {
            var result = await _productService.GetProductByIdAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Get products with search criteria
        [HttpPost("search")]
        public async Task<IResult> GetProducts([FromBody] SearchProductRequest request)
        {
            var result = await _productService.GetProductsAsync(request);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Products retrieved successfully")
                : ResultExtensions.ToProblemDetails(result);
        }


        // Add a new product
        [HttpPost("add")]
        public async Task<IResult> AddProduct([FromBody] AddProductRequest addProductRequest)
        {
            var result = await _productService.AddProductAsync(addProductRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product added successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Update a product
        [HttpPut("update")]
        public async Task<IResult> UpdateProduct([FromBody] UpdateProductRequest updateProductRequest)
        {
            var result = await _productService.UpdateProductAsync(updateProductRequest);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product updated successfully")
                : ResultExtensions.ToProblemDetails(result);
        }

        // Delete a product
        [HttpDelete("delete/{id}")]
        public async Task<IResult> DeleteProduct(Guid id)
        {
            var result = await _productService.DeleteProductAsync(id);
            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Product deleted successfully")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
