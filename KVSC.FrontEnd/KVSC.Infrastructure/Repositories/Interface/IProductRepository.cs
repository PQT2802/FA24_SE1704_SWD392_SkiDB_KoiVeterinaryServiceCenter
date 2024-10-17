using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Repositories.Interface
{
    public interface IProductRepository
    {
        Task<ResponseDto<GetMedicine>> GetMedicines();
    }
}
