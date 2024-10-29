using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.DTOs.PetService
{
    public class UploadImageRequest
    {
        public IFormFile ImageFile { get; set; }
        public Guid Id {  get; set; }

    }
}
