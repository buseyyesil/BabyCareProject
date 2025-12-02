using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            createTestimonialDto.CreatedDate = DateTime.Now;
            await _testimonialService.CreateTestimonialAsync(createTestimonialDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateTestimonial(string id)
        {
            var value = await _testimonialService.GetTestimonialByIdAsync(id);
            var updateDto = new UpdateTestimonialDto
            {
                TestimonialId = value.TestimonialId,
                Name = value.Name,
                Position = value.Position,
                Comment = value.Comment,
                ImageUrl = value.ImageUrl,
                Rating = value.Rating,
                CreatedDate = value.CreatedDate,
                Order = value.Order,
                IsActive = value.IsActive
            };
            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            await _testimonialService.UpdateTestimonialAsync(updateTestimonialDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteTestimonial(string id)
        {
            await _testimonialService.DeleteTestimonialAsync(id);
            return RedirectToAction("Index");
        }
    }
}