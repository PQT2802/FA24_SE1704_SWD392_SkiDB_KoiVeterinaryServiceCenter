using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KoiVeterinaryServiceCenter_FE.Pages.User.Admin
{
    public class DashboardModel : PageModel
    {
        public List<DynamicFormField> FormFields { get; set; }

        public void OnGet()
        {
            FormFields = new List<DynamicFormField>
            {
                new DynamicFormField { Label = "Service Name", FieldType = "text", Name = "Name", Placeholder = "Enter service name", Required = true },
                new DynamicFormField { Label = "Description", FieldType = "textarea", Name = "Description", Placeholder = "Enter description", Required = true },
                new DynamicFormField { Label = "Price", FieldType = "number", Name = "Price", Placeholder = "Enter price", Required = true },
                new DynamicFormField { Label = "Category ID", FieldType = "number", Name = "PetCategoryId", Placeholder = "Enter category ID", Required = true }
            };
        }
    }
}
