using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Dashboard.Admin
{
    public class TopService
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal AverageRating { get; set; }
    }
}
