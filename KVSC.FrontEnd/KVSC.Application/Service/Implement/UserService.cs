using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.User;
using KVSC.Infrastructure.Repositories.Interface;

namespace KVSC.Application.Service.Implement;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ResponseDto<List<VeterinarianInfo>>> GetAllVeterinariansAsync()
    {
        // Optionally, add any additional business logic here if needed
        return await _userRepository.GetAllVeterinariansAsync();
    }
}
