using BabyCareProject.Dtos.FooterDtos.FooterInformationDtos;
using BabyCareProject.Services.FooterServices.FooterInformationServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FooterInformationController : Controller
    {
        private readonly IFooterInformationService _footerInformationService;

        public FooterInformationController(IFooterInformationService footerInformationService)
        {
            _footerInformationService = footerInformationService;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _footerInformationService.GetFooterInformationAsync();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateFooterInformation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterInformation(CreateFooterInformationDto createFooterInformationDto)
        {
            await _footerInformationService.CreateFooterInformationAsync(createFooterInformationDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateFooterInformation(string id)
        {
            var value = await _footerInformationService.GetFooterInformationByIdAsync(id);
            var updateDto = new UpdateFooterInformationDto
            {
                FooterInformationId = value.FooterInformationId,
                Description = value.Description,
                Address = value.Address,
                Phone = value.Phone,
                Email = value.Email,
                FacebookUrl = value.FacebookUrl,
                TwitterUrl = value.TwitterUrl,
                InstagramUrl = value.InstagramUrl,
                LinkedInUrl = value.LinkedInUrl
            };
            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFooterInformation(UpdateFooterInformationDto updateFooterInformationDto)
        {
            await _footerInformationService.UpdateFooterInformationAsync(updateFooterInformationDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteFooterInformation(string id)
        {
            await _footerInformationService.DeleteFooterInformationAsync(id);
            return RedirectToAction("Index");
        }
    }
}