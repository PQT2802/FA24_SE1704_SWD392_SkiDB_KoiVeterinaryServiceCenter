using KVSC.Application.Common;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly IVnPaymentService _vnPaymentService;

        public PaymentController(IVnPaymentService vnPaymentService)
        {
            _vnPaymentService = vnPaymentService;
        }

        // POST: api/payment/create-payment-url
        [HttpPost("create-payment-url")]
        [Authorize]
        public async Task<IResult> CreatePaymentUrl([FromQuery] double depositMoney)
        {
            CurrentUserObject currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            Result result = await _vnPaymentService.CreatePaymentUrl(HttpContext, depositMoney, currentUser.UserId);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payment URL created successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // GET: api/payment/callback
        [HttpGet("callback")]
        public async Task<IResult> PaymentCallback([FromQuery] Guid userId, [FromQuery] double depositMoney)
        {
            var collections = HttpContext.Request.Query;
            Result result = await _vnPaymentService.PaymentExecute(collections, userId, depositMoney);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Payment executed successfully.")
                : ResultExtensions.ToProblemDetails(result);
        }
    }
}
