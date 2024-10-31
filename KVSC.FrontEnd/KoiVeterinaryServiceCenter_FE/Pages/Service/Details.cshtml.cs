using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs.Rating;
using KVSC.Infrastructure.DTOs.Service.ServiceDetail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.Service;

public class DetailsModel : PageModel
{
    private readonly IPetServiceService _petServiceService;
    private readonly IRatingService _ratingService;
    public DetailsModel(IPetServiceService petServiceService, IRatingService ratingService)
    {
        _petServiceService = petServiceService;
        _ratingService = ratingService;
    }

    public PetServiceDto ServiceDetails { get; set; }
    public string ErrorMessage { get; set; }
    public RatingList Ratings { get; set; }

    // Thêm các thuộc tính cho tìm kiếm và phân trang
    [BindProperty(SupportsGet = true)]
    public int Score { get; set; } // Điểm tìm kiếm

    [BindProperty(SupportsGet = true)]
    public DateTime? CreatedDate { get; set; } = null; // Ngày tạo tìm kiếm

    [BindProperty(SupportsGet = true)]
    public int PageNumber { get; set; } = 1; // Số trang

    [BindProperty(SupportsGet = true)]
    public int PageSize { get; set; } = 10; // Kích thước trang

    public async Task<IActionResult> OnGetAsync(Guid id, int score = 0, DateTime? createdDate = null, int pageNumber = 1, int pageSize = 10)
    {
        if (id == Guid.Empty)
        {
            return NotFound(); 
        }

        var result = await _petServiceService.GetPetServiceByIdAsync(id);
        if (result.IsSuccess)
        {
            ServiceDetails = result.Data ?? new PetServiceDto();  

            // Get all rating
            var ratingResult = await _ratingService.GetAllRatingsByServiceIdAsync(id, score, createdDate, pageNumber, pageSize);
            if (ratingResult.IsSuccess)
            {
                Ratings = ratingResult.Data ?? new RatingList(); 
            }
            else
            {
                ErrorMessage = ratingResult.Message ?? string.Empty;
                Ratings = new RatingList();  
            }

            return Page();
        }
        else
        {
            ErrorMessage = result.Message ?? string.Empty;  
            return Page();
        }
    }
}
