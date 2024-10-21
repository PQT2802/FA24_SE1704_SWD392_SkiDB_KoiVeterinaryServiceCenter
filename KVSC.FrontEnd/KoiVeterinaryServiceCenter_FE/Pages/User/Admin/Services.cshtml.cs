﻿using KVSC.Application.Service.Interface;
using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KVSC.Infrastructure.DTOs.Service;
using KVSC.Infrastructure.DTOs.Service.AddService;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;
using KVSC.Infrastructure.DTOs.Service.UpdateService;
using KVSC.Application.Service.Implement;
using KVSC.Infrastructure.DTOs.Service.DeleteService;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class ServicesModel : PageModel
    {
        private readonly IPetServiceService _petServiceSerivce;
        private readonly IPetServiceCategoryService _petServiceCategoryService;

        [BindProperty]
        public KoiServiceList KoiServiceList { get; set; } = default!;

        [BindProperty]
        public AddServiceRequest AddServiceRequest { get; set; } = default!;
        public bool ShowModal { get; set; } = false;

        [BindProperty]
        public UpdateServiceRequest UpdateServiceRequest { get; set; } = default!;

        public List<KoiServiceCategoryList> Categories { get; set; } = new List<KoiServiceCategoryList>();

        public ServicesModel(IPetServiceService petServiceSerivce , IPetServiceCategoryService petServiceCategoryService)
        {
            _petServiceSerivce = petServiceSerivce;
            _petServiceCategoryService = petServiceCategoryService;
        }

        public async Task<IActionResult> OnPostCreateServiceAsync()
        {
            var result = await _petServiceSerivce.AddPetService(AddServiceRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
                // return RedirectToPage("/User/Admin/Services");
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
        }

        public async Task<IActionResult> OnPostUpdateServiceAsync()
        {
            var result = await _petServiceSerivce.UpdatePetService(UpdateServiceRequest);

            if (result.IsSuccess)
            {
                return new JsonResult(new { isSuccess = true });
                // return RedirectToPage("/User/Admin/Services");
            }

            var errors = ProcessErrors(result.Errors);
            return new JsonResult(new { isSuccess = false, errors });
        }

        public async Task<IActionResult> OnPostDeleteServiceAsync(Guid Id)
        {
            var request = new DeleteServiceRequest { Id = Id }; // Khởi tạo đối tượng DeleteServiceRequest
            var result = await _petServiceSerivce.DeletePetService(request);

            if (result.IsSuccess)
            {
                TempData["SuccessMessage"] = "Service deleted successfully."; // Lưu thông báo vào TempData
                TempData["AlertClass"] = "alert-success";
                return RedirectToPage("/User/Admin/Services");
            }

            TempData["ErrorMessage"] = "Failed to delete service: " + string.Join(", ", result.Errors.Select(e => e.Description));
            return RedirectToPage("/User/Admin/Services");
        }
        private Dictionary<string, string> ProcessErrors(List<ErrorDetail>? errors)
        {
            var errorDictionary = new Dictionary<string, string>();

            if (errors != null)
            {
                foreach (var error in errors)
                {
                    switch (error.Code)
                    {
                        case "PetService.Empty":
                            if (error.Description.Contains("Name", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Name"] = error.Description;
                            else if (error.Description.Contains("Duration", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["Duration"] = error.Description;
                            else if (error.Description.Contains("ImageUrl", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["ImageUrl"] = error.Description;
                            break;
                        case "PetService.InvalidValue":
                            if (error.Description.Contains("BasePrice", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["BasePrice"] = error.Description;
                            else if (error.Description.Contains("TravelCost", StringComparison.OrdinalIgnoreCase))
                                errorDictionary["TravelCost"] = error.Description;
                            break;
                        case "PetService.InvalidDate":
                            errorDictionary["AvailableFrom"] = error.Description;
                            break;
                        // Bạn có thể thêm các trường hợp khác ở đây
                        default:
                            errorDictionary[string.Empty] = error.Description;
                            break;
                    }
                }
            }

            return errorDictionary;
        }

        public async Task OnGetAsync()
        {
            var result = await _petServiceSerivce.GetKoiServiceList();
            if (result.IsSuccess)
            {
            
                KoiServiceList = result.Data;
                // Kiểm tra và khởi tạo Extensions nếu cần
                if (KoiServiceList.Extensions == null)
                {
                    KoiServiceList.Extensions = new Extensions<List<Data>>
                    {
                        Data = new List<Data>() 
                    };
                }
            }
            else
            {
                KoiServiceList = new KoiServiceList
                {
                    Extensions = new Extensions<List<Data>> { Data = new List<Data>() }
                };
            }
            // Gán dữ liệu vào ViewBag cho dropdown
            var categoryResult = await _petServiceCategoryService.GetKoiServiceCategoryList();
            var category = categoryResult.Data.Extensions.Data;
            if (categoryResult.IsSuccess)
            {
                ViewData["Categories"] = new SelectList(category, "Id", "Name");  // Gán danh sách categories vào ViewData
            }
            else
            {
                ViewData["Categories"] = new List<KoiServiceCategory>(); // Nếu có lỗi, gán danh sách rỗng
            }

        }
    }
}