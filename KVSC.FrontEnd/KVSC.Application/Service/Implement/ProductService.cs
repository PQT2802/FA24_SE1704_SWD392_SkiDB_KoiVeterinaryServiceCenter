using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Product;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ResponseDto<GetMedicine>> GetMedicines()
        {
            var result = await _productRepository.GetMedicines();

            // Add any additional business logic or transformations here

            return result;
        }
    }
}
