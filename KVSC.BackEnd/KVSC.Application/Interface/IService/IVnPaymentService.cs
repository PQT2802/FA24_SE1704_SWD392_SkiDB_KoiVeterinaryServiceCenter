using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Schedule;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVSC.Application.Interface.IService
{
    public interface IVnPaymentService
    {
        Task<Result> CreatePaymentUrl(HttpContext context, double depositMoney, Guid userId);
        Task<Result> PaymentExecute(IQueryCollection collections, Guid userId, double depositMoney);
    }
}

