using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;

namespace KVSC.Application.Service.Interface;

public interface IUserService
{
    Task<ResponseDto<List<VeterinarianInfo>>> GetAllVeterinariansAsync();
}