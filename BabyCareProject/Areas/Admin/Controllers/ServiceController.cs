using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        // Liste
        public async Task<IActionResult> Index()
        {
            var values = await _serviceService.GetAllServiceAsync();
            return View(values);
        }

        // Create GET
        [HttpGet]
        public IActionResult CreateService()
        {
            return View();
        }

        // Create POST
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            await _serviceService.CreateServiceAsync(createServiceDto);
            return RedirectToAction("Index");
        }

        // Update GET
        [HttpGet]
        public async Task<IActionResult> UpdateService(string id)
        {
            var value = await _serviceService.GetServiceByIdAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            var updateDto = new UpdateServiceDto
            {
                ServiceId = value.ServiceId,
                Title = value.Title,
                Description = value.Description,
                IconClass = value.IconClass,
                ImageUrl = value.ImageUrl,
                Order = value.Order,
                IsActive = value.IsActive
            };

            return View(updateDto);
        }

        // Update POST
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto updateServiceDto)
        {
            await _serviceService.UpdateServiceAsync(updateServiceDto);
            return RedirectToAction("Index");
        }

        // Silme
        public async Task<IActionResult> DeleteService(string id)
        {
            await _serviceService.DeleteServiceAsync(id);
            return RedirectToAction("Index");
        }
    }
}
