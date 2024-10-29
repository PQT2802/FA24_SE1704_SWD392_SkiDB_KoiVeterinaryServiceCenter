using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Rating;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Manager
{
    public class RatingModel : PageModel
    {
        private readonly IRatingService _ratingService;

        [BindProperty]
        public RatingList RatingList { get; set; } = default!;
        public bool ShowModal { get; set; } = false;
        // Filter criteria
        [BindProperty(SupportsGet = true)]
        public string CustomerName { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string Feedback { get; set; } = string.Empty;

        [BindProperty(SupportsGet = true)]
        public int Score { get; set; } = -1; // Assuming -1 means no filter

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 10;

        public RatingModel(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        public async Task OnGetAsync()
        {
            await SearchRatingsAsync();
        }

        public async Task SearchRatingsAsync()
        {
            var result = await _ratingService.GetManagerRatingList(CustomerName, Feedback, Score, PageNumber, PageSize);
            if (result.IsSuccess)
            {
                RatingList = result.Data ?? new RatingList();
            }
            else
            {
                RatingList = new RatingList();
            }
        }
    }
}
