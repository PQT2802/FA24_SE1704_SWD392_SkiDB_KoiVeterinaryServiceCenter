using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Firebase.GetImage;
using Microsoft.AspNetCore.Http;

namespace KVSC.Application.Interface.IService
{
    public interface IFirebaseService
    {
        Task<Result> UploadImageAsync(IFormFile file, string folder);
        Task<Result> GetImageAsync(GetImageRequest request);
    }
}
