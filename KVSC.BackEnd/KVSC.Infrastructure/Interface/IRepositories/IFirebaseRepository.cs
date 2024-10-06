﻿using KVSC.Infrastructure.DTOs.Firebase.AddImage;
using KVSC.Infrastructure.DTOs.Firebase.GetImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Infrastructure.Interface.IRepositories
{
    public interface IFirebaseRepository
    {
        Task<AddImageResponse> UploadImageAsync(AddImageRequest request);
        Task<GetImageResponse> GetImageAsync(GetImageRequest request);
    }
}
