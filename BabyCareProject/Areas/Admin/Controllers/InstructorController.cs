using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController : Controller
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _instructorService.GetAllInstructorAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateInstructor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstructor(CreateInstructorDto createInstructorDto)
        {
            await _instructorService.CreateInstructorAsync(createInstructorDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteInstructor(string id)
        {
            await _instructorService.DeleteInstructorAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateInstructor(string id)
        {
            var value = await _instructorService.GetInstructorByIdAsync(id);

            var model = new UpdateInstructorDto
            {
                InstructorId = value.InstructorId,
                FirstName = value.FirstName,
                LastName = value.LastName,
                Title = value.Title,
                ImageUrl = value.ImageUrl
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInstructor(UpdateInstructorDto updateInstructorDto)
        {
            await _instructorService.UpdateInstructorAsync(updateInstructorDto);
            return RedirectToAction("Index");
        }
    }
}
