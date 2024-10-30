using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Manager
{
    public class RatingModel : PageModel
    {
        private readonly IRatingService _ratingService;
        private readonly IPetServiceService _petServiceService;

        [BindProperty]
        public RatingList RatingList { get; set; } = default!;
        public bool ShowModal { get; set; } = false;

        // Filter criteria
        [BindProperty(SupportsGet = true)]
        public Guid ServiceId { get; set; } = Guid.Empty;

        [BindProperty(SupportsGet = true)]
        public int Score { get; set; } = 0;

        [BindProperty(SupportsGet = true)]
        public DateTime? CreatedDate { get; set; } = null;

        [BindProperty(SupportsGet = true)]
        public int PageNumber { get; set; } = 1;

        [BindProperty(SupportsGet = true)]
        public int PageSize { get; set; } = 10;

        public RatingModel(IRatingService ratingService, IPetServiceService petServiceService)
        {
            _ratingService = ratingService;
            _petServiceService = petServiceService;
        }

        public async Task OnGetAsync()
        {
            try
            {
                if (ServiceId == Guid.Empty && Score == 0 && !CreatedDate.HasValue)
                {
                    var result = await _ratingService.GetAllRatings(PageNumber, PageSize);
                    if (result.IsSuccess)
                    {
                        RatingList = result.Data ?? new RatingList();
                    }
                    else
                    {
                        RatingList = new RatingList();
                    }

                    // Fetch the Koi service list for dropdown
                    var serviceResult = await _petServiceService.GetKoiServiceList();
                    if (serviceResult.IsSuccess && serviceResult.Data?.Extensions?.Data != null)
                    {
                        var services = serviceResult.Data.Extensions.Data;
                        var serviceListWithEmptyOption = new List<Data> { new Data { Id = Guid.Empty, Name = "All Services" } };
                        serviceListWithEmptyOption.AddRange(services);

                        ViewData["Services"] = new SelectList(serviceListWithEmptyOption, "Id", "Name", Guid.Empty);
                    }
                    else
                    {
                        ViewData["Services"] = new List<Data>();
                    }
                }
                else
                {
                    await SearchRatingsAsync();
                }
            }
            catch (Exception ex)
            {
                RedirectToPage("/Errors/404");
            }
        }


        public async Task SearchRatingsAsync()
        {
            try
            {
                // Fetch the rating list
                var result = await _ratingService.GetManagerRatingList(ServiceId, Score, CreatedDate, PageNumber, PageSize);
                if (result.IsSuccess)
                {
                    RatingList = result.Data ?? new RatingList();
                }
                else
                {
                    RatingList = new RatingList();
                }
                // Fetch the Koi service list for dropdown
                var serviceResult = await _petServiceService.GetKoiServiceList();
                if (serviceResult.IsSuccess && serviceResult.Data?.Extensions?.Data != null)
                {
                    // Make a list of services and add an empty option at the beginning
                    var services = serviceResult.Data.Extensions.Data;
                    var serviceListWithEmptyOption = new List<Data> { new Data { Id = Guid.Empty, Name = "All Services" } };
                    serviceListWithEmptyOption.AddRange(services);

                    ViewData["Services"] = new SelectList(serviceListWithEmptyOption, "Id", "Name");
                }
                else
                {
                    ViewData["Services"] = new List<Data>();
                }
            }
            catch (Exception ex)
            {
                RedirectToPage("/Errors/404");
            }
        }
    }
}
