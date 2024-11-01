using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Rating.GetRatingDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Manager
{
    public class RatingDetailModel : PageModel
    {
        private readonly IRatingService _ratingService;

        [BindProperty]
        public GetRatingResponse RatingDetail { get; set; } = new();

        public RatingDetailModel(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task<IActionResult> OnGetAsync(Guid serviceId)
        {
            var result = await _ratingService.GetRatingDetail(serviceId);
            if (result.IsSuccess)
            {
                RatingDetail = result.Data ?? new GetRatingResponse();
            }
            else
            {
                RatingDetail = new GetRatingResponse();
            }
            if (RatingDetail == null)
            {
                return RedirectToPage("/Error");
            }
            return Page();
        }
    }
}
