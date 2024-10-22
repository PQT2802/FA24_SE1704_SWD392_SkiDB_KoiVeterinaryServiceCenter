using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User.UpdateUser
{
    public class UpdateUserResponse
    {
        public Extensions<UserUpdateData> Extensions { get; set; }
    }
    public class UserUpdateData
    {
        public Guid Id { get; set; }
    }
}
