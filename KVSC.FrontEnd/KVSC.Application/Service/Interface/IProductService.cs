using KVSC.Infrastructure.DTOs.Product;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Interface
{
    public interface IProductService
    {
        Task<ResponseDto<GetMedicine>> GetMedicines();
    }
}
