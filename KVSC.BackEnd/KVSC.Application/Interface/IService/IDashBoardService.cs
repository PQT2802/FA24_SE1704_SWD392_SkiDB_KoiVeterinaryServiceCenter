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
        //ADMIN
        Task<Result> GetAdminDashboardDataAsync(Guid adminId);

        //VET
        Task<Result> GetVeterinarianDashboardDataAsync(Guid veterinarianId);

        //MANAGER
        Task<Result> GetManagerDashboardDataAsync(Guid managerId);

        //CUSTOMER
        Task<Result> GetCustomerDashboardDataAsync(Guid customerId);
    }
}
