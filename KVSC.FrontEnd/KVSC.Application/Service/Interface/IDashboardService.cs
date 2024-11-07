using KVSC.Infrastructure.DTOs.Dashboard.Customer;
using KVSC.Infrastructure.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DTOs.Dashboard.Manager;
using KVSC.Infrastructure.DTOs.Dashboard.Veterinarian;
using KVSC.Infrastructure.DTOs.Dashboard.Admin;

namespace KVSC.Application.Service.Interface
{
    public interface IDashboardService
    {
        Task<ResponseDto<GetCusDashboardResponse>> GetCustomerDashboardAsync(Guid customerId);
        Task<ResponseDto<GetManagerDashboardResponse>> GetManagerDashboardAsync(Guid managerId);
        Task<ResponseDto<GetVetDashboardResponse>> GetVetDashboardAsync(Guid veterinarianId);
        Task<ResponseDto<GetAdminDashboardResponse>> GetAdminDashboardAsync(Guid adminId);

    }
}
