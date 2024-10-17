using KVSC.Domain.Entities;
using KVSC.Infrastructure.DB;
using KVSC.Infrastructure.Interface.IRepositories;
using KVSC.Infrastructure.KVSC.Infrastructure.Implement.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Implement.Repositories
{
        public class PrescriptionRepository : GenericRepository<Prescription>,IPrescriptionRepository
        {
            public PrescriptionRepository(KVSCContext context) : base(context) { }

        }
}
