using BabyCareProject.Dtos.FooterDtos.FooterGalleryDtos;
using BabyCareProject.Services.FooterServices.FooterGalleryServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FooterGalleryController : Controller
    {
        private readonly IFooterGalleryService _footerGalleryService;

        public FooterGalleryController(IFooterGalleryService footerGalleryService)
        {
            _footerGalleryService = footerGalleryService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _footerGalleryService.GetAllFooterGalleryAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFooterGallery()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterGallery(CreateFooterGalleryDto createFooterGalleryDto)
        {
            await _footerGalleryService.CreateFooterGalleryAsync(createFooterGalleryDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFooterGallery(string id)
        {
            var value = await _footerGalleryService.GetFooterGalleryByIdAsync(id);
            var updateDto = new UpdateFooterGalleryDto
            {
                FooterGalleryId = value.FooterGalleryId,
                ImageUrl = value.ImageUrl,
                Title = value.Title,
                Order = value.Order,
                IsActive = value.IsActive
            };
            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFooterGallery(UpdateFooterGalleryDto updateFooterGalleryDto)
        {
            await _footerGalleryService.UpdateFooterGalleryAsync(updateFooterGalleryDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFooterGallery(string id)
        {
            await _footerGalleryService.DeleteFooterGalleryAsync(id);
            return RedirectToAction("Index");
        }
    }
}