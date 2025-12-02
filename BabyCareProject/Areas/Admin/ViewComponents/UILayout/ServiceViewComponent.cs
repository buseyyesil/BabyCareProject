using BabyCareProject.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.ViewComponents.UILayout
{
    [ViewComponent(Name = "ServiceViewComponent")]
    public class ServiceViewComponent : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ServiceViewComponent(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _serviceService.GetActiveServicesAsync();
            return View(values);
        }
    }
}