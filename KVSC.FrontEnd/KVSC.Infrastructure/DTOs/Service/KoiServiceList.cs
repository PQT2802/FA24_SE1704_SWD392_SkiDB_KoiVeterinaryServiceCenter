using KVSC.Infrastructure.DTOs.User.Login;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.Service
{
    public class KoiServiceList 
    {
        public Extensions<List<Data>> Extensions { get; set; }

    }
    public class Data : IPropertyNameProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid PetServiceCategoryId { get; set; }
        public decimal BasePrice { get; set; }
        public string Duration { get; set; }
        public string Img { get; set; }

        public List<string> GetPropertyNames()
        {
            return new List<string> { nameof(Id), nameof(Name), nameof(PetServiceCategoryId), nameof(BasePrice), nameof(Duration) };
        }
    }
}
