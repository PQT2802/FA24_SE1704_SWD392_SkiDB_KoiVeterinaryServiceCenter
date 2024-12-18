﻿using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class GenericTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<IPropertyNameProvider> items, string listType)
        {
            var model = new GenericTableViewModel
            {
                Items = items.ToList(),
                PropertyNames = items.FirstOrDefault()?.GetPropertyNames() ?? new List<string>(),
                ListType = listType,
                UserRole = HttpContext.User.IsInRole("Veterinarian") ? "Veterinarian" : "Customer" // Set UserRole here

            };

            return View(model);
        }
    }
}
