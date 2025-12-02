using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController : Controller
    {
        private readonly IAboutService _AboutService;

        public AboutController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _AboutService.GetAllAboutAsync();
            return View(values);
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
        {
            await _AboutService.CreateAboutAsync(createAboutDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _AboutService.DeleteAboutAsync(id);
            return RedirectToAction("Index");
        }

        // GET: UpdateAbout
        public async Task<IActionResult> UpdateAbout(string id)
        {
            // Servisten gelen büyük ihtimalle ResultAboutDto
            var value = await _AboutService.GetAboutByIdAsync(id);

            if (value == null)
            {
                return NotFound();
            }

            // Bunu basitçe UpdateAboutDto'ya çeviriyoruz
            var model = new UpdateAboutDto
            {
                AboutId = value.AboutId,
                Title = value.Title,
                Description = value.Description,
                ImageUrl = value.ImageUrl,
                VideoUrl = value.VideoUrl,
                YearsOfExperience = value.YearsOfExperience,
                HappyChildren = value.HappyChildren,
                QualifiedTeachers = value.QualifiedTeachers,
                ActivePrograms = value.ActivePrograms
            };

            return View(model);
        }

        // POST: UpdateAbout
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            await _AboutService.UpdateAboutAsync(updateAboutDto);
            return RedirectToAction("Index");
        }
    }
}
