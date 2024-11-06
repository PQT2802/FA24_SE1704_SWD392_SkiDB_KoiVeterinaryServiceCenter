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
        Task<Result> GetDashboardDataAsync(int topCount = 5);
        Task<Result> GetTopVeterinariansAsync(int topCount);
        Task<Result> GetBestServicesAsync(int topCount);
        Task<Result> GetTopSellingProductsAsync(int topCount);

        //VET
        Task<Result> GetVeterinarianDashboardDataAsync();
        Task<Result> GetNewestCompletedAppointmentsAsync();
        Task<Result> GetNextUpcomingAppointmentsAsync();

        //MANAGER
        Task<Result> GetManagerDashboardDataAsync();
        Task<Result> GetServiceReportsAsync();
        Task<Result> GetManageDetailAsync();

        //CUSTOMER
        Task<Result> GetCustomerDashboardDataAsync(Guid customerId);
    }
}
