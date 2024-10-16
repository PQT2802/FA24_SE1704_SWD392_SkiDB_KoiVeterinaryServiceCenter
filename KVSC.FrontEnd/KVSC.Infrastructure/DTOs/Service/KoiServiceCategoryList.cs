using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service
{
    public class KoiServiceCategoryList
    {
        public Extensions<List<DataKoiServiceCategory>> Extensions { get; set; }
    }
    public class DataKoiServiceCategory : IPropertyNameProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public string serviceType { get; set; }
        public string applicableTo { get; set; }

        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(Name), nameof(description), nameof(serviceType), nameof(applicableTo) };
        }
    }
}
