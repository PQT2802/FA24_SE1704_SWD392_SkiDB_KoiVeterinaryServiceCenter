using KVSC.Application.Common;
using KVSC.Application.Interface.IService;
using KVSC.Application.KVSC.Application.Common.Result;
using KVSC.Infrastructure.DTOs.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KVSC.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        private readonly IWalletService _walletService;

        public WalletController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        // POST: api/wallet/deposit
        [HttpPost("deposit")]
        [Authorize]
        public async Task<IResult> DepositPayment([FromQuery] Guid appointmentId, [FromQuery] decimal depositAmount)
        {
            CurrentUserObject currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _walletService.DepositPaymentAsync(currentUser.UserId, appointmentId, depositAmount);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Deposit payment successfully made.")
                : ResultExtensions.ToProblemDetails(result);
        }

        // POST: api/wallet/total-amount
        [HttpPost("total-amount")]
        [Authorize]
        public async Task<IResult> TotalAmountPayment([FromQuery] Guid appointmentId, [FromQuery] decimal totalAmount)
        {
            CurrentUserObject currentUser = await TokenHelper.Instance.GetThisUserInfo(HttpContext);
            var result = await _walletService.TotalAmountPaymentAsync(currentUser.UserId, appointmentId, totalAmount);

            return result.IsSuccess
                ? ResultExtensions.ToSuccessDetails(result, "Total amount payment successfully made.")
                : ResultExtensions.ToProblemDetails(result);
        }
    }

}
