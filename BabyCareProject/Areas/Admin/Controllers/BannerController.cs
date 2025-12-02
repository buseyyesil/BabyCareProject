using BabyCareProject.Dtos.BannerDtos;
using BabyCareProject.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController : Controller
    {
        private readonly IBannerService _bannerService;

        public BannerController(IBannerService bannerService)
        {
            _bannerService = bannerService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.GetAllBannerAsync();
            return View(values);
        }

        public IActionResult CreateBanner()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBannerDto)
        {
            await _bannerService.CreateBannerAsync(createBannerDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteBanner(string id)
        {
            await _bannerService.DeleteBannerAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateBanner(string id)
        {
            var value = await _bannerService.GetBannerByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            await _bannerService.UpdateBannerAsync(updateBannerDto);
            return RedirectToAction("Index");
        }
    }
}