using KVSC.Infrastructure.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace KoiVeterinaryServiceCenter_FE.ViewComponents
{
    public class GenericTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(IEnumerable<IPropertyNameProvider> items)
        {
            var model = new GenericTableViewModel
            {
                Items = items.ToList(),
                PropertyNames = items.FirstOrDefault()?.GetPropertyNames() ?? new List<string>()
            };

            return View(model);
        }
    }
}
