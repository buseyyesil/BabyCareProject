using BabyCareProject.Dtos.FooterDtos.FooterSubscribeDtos;
using BabyCareProject.Services.FooterServices.FooterSubscribeServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FooterSubscribeController : Controller
    {
        private readonly IFooterSubscribeService _footerSubscribeService;

        public FooterSubscribeController(IFooterSubscribeService footerSubscribeService)
        {
            _footerSubscribeService = footerSubscribeService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _footerSubscribeService.GetAllFooterSubscribeAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateFooterSubscribe()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterSubscribe(CreateFooterSubscribeDto createFooterSubscribeDto)
        {
            createFooterSubscribeDto.SubscribeDate = DateTime.Now;
            createFooterSubscribeDto.IsActive = true;
            await _footerSubscribeService.CreateFooterSubscribeAsync(createFooterSubscribeDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFooterSubscribe(string id)
        {
            var value = await _footerSubscribeService.GetFooterSubscribeByIdAsync(id);
            var updateDto = new UpdateFooterSubscribeDto
            {
                FooterSubscribeId = value.FooterSubscribeId,
                Email = value.Email,
                SubscribeDate = value.SubscribeDate,
                IsActive = value.IsActive
            };
            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFooterSubscribe(UpdateFooterSubscribeDto updateFooterSubscribeDto)
        {
            await _footerSubscribeService.UpdateFooterSubscribeAsync(updateFooterSubscribeDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFooterSubscribe(string id)
        {
            await _footerSubscribeService.DeleteFooterSubscribeAsync(id);
            return RedirectToAction("Index");
        }
    }
}