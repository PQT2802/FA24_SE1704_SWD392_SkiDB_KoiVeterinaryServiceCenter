using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.User.DeleteUser
{
    public class DeleteUserResponse
    {
        public Extensions<DeleteUserData> Extensions { get; set; }
    }
    public class DeleteUserData
    {
        public Guid Id { get; set; }
    }
}
