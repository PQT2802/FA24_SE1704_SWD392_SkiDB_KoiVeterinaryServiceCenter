using KVSC.Infrastructure.DTOs.Product.AddProduct;
using KVSC.Application.KVSC.Application.Common.Result;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Product.UpdateProduct;
using KVSC.Infrastructure.DTOs.Product.SearchProduct;

namespace KVSC.Application.Interface.IService
{
    public interface IProductService
    {
        Task<Result> AddProductAsync(AddProductRequest addProductRequest);
        Task<Result> UpdateProductAsync(UpdateProductRequest updateProductRequest);
        Task<Result> DeleteProductAsync(Guid productId);
        Task<Result> GetProductByIdAsync(Guid id);
        Task<Result> GetProductsAsync(SearchProductRequest request);
    }
}

