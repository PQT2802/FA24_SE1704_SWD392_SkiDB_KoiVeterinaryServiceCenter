using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;

namespace KVSC.Infrastructure.KVSC.Infrastructure.Common
{
    
    public class UnitOfWork
    {
        private KVSCContext _unitOfWorkContext;
        public UserRepository _userRepository;

        public UnitOfWork()
        {
            _unitOfWorkContext ??= new KVSCContext();
        }
        public UserRepository UserRepository { get { return _userRepository; } }

    }
}
