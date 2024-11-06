using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Dashboard.Customer;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.Repositories.Implement;
using KVSC.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Service.Implement
{
    public class DashboardService : IDashboardService
    {
        private readonly IDashboardRepository _dashboardRepository;

        public DashboardService(IDashboardRepository dashboardRepository)
        {
            _dashboardRepository = dashboardRepository;
        }

        public async Task<ResponseDto<GetCusDashboardResponse>> GetCustomerDashboardAsync(Guid customerId)
        {
            var response = await _dashboardRepository.GetCustomerDashboardAsync(customerId);
            return response;
        }

        public async Task<ResponseDto<GetManagerDashboardResponse>> GetManagerDashboardAsync(Guid managerId)
        {
            var response = await _dashboardRepository.GetManagerDashboardAsync(managerId);
            return response;
        }
    }
}
