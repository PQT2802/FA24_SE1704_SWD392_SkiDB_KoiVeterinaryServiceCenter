using KVSC.Application.KVSC.Application.Common.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IDashBoardService
    {
        Task<Result> GetTopVeterinariansAsync(int topCount);
        Task<Result> GetBestServicesAsync(int topCount);
        Task<Result> GetTopSellingProductsAsync(int topCount);
    }
}
